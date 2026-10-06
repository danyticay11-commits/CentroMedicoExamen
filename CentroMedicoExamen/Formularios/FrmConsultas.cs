using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CentroMedicoExamen.Datos;
using System.Data;

namespace CentroMedicoExamen.Formularios
{
    public partial class FrmConsultas : Form
    {
        public FrmConsultas()
        {
            InitializeComponent();

            CargarCitas();
            CargarConsultas();

        }

        private void CargarCitas()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"SELECT 
                                C.ID_Cita,
                                P.Nombre + ' ' + P.Apellido
                                + ' - ' +
                                M.Nombre + ' ' + M.Apellido
                                + ' - ' +
                                CONVERT(varchar(16), C.FechaHora, 120)
                                AS Descripcion
                                FROM Med_Citas C
                                INNER JOIN Med_Pacientes P
                                ON C.ID_Paciente = P.ID_Paciente
                                INNER JOIN Med_Medicos M
                                ON C.ID_Medico = M.ID_Medico";

                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    cmbCita.DataSource = tabla;
                    cmbCita.DisplayMember = "Descripcion";
                    cmbCita.ValueMember = "ID_Cita";
                    cmbCita.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla citas: " + ex.Message);
            }
        }

        private void CargarConsultas()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"SELECT 
                                CO.ID_Consulta,
                                CO.ID_Cita,
                                P.Nombre + ' ' + P.Apellido AS Paciente,
                                M.Nombre + ' ' + M.Apellido AS Medico,
                                CO.FechaConsulta,
                                CO.Sintomas,
                                CO.Diagnostico,
                                CO.NotasMedicas
                                FROM Med_Consultas CO
                                INNER JOIN Med_Citas C
                                ON CO.ID_Cita = C.ID_Cita
                                INNER JOIN Med_Pacientes P
                                ON C.ID_Paciente = P.ID_Paciente
                                INNER JOIN Med_Medicos M
                                ON C.ID_Medico = M.ID_Medico";

                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgvConsultas.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla consultas: " + ex.Message);
            }
        }


        private void lblFechaConsulta_Click(object sender, EventArgs e)
        {

        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCita.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una cita.");
                    return;
                }

                if (txtSintomas.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese los síntomas.");
                    return;
                }

                if (txtDiagnostico.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el diagnóstico.");
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"INSERT INTO Med_Consultas
                                (ID_Cita, FechaConsulta, Sintomas,
                                 Diagnostico, NotasMedicas)
                                VALUES
                                (@cita, @fecha, @sintomas,
                                 @diagnostico, @notas)";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue(
                        "@cita",
                        cmbCita.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@fecha",
                        dtpFechaConsulta.Value);

                    cmd.Parameters.AddWithValue(
                        "@sintomas",
                        txtSintomas.Text);

                    cmd.Parameters.AddWithValue(
                        "@diagnostico",
                        txtDiagnostico.Text);

                    cmd.Parameters.AddWithValue(
                        "@notas",
                        txtNotasMedicas.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Consulta guardada correctamente.");

                    CargarConsultas();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar consulta: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            cmbCita.SelectedIndex = -1;

            dtpFechaConsulta.Value = DateTime.Now;

            txtSintomas.Clear();
            txtDiagnostico.Clear();
            txtNotasMedicas.Clear();
        }

        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvConsultas.Rows[e.RowIndex];

                cmbCita.SelectedValue =
                    fila.Cells["ID_Cita"].Value;

                if (fila.Cells["FechaConsulta"].Value != DBNull.Value)
                {
                    dtpFechaConsulta.Value =
                        Convert.ToDateTime(
                            fila.Cells["FechaConsulta"].Value);
                }

                txtSintomas.Text =
                    fila.Cells["Sintomas"].Value?.ToString();

                txtDiagnostico.Text =
                    fila.Cells["Diagnostico"].Value?.ToString();

                txtNotasMedicas.Text =
                    fila.Cells["NotasMedicas"].Value?.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvConsultas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una consulta.");
                return;
            }

            try
            {
                int idConsulta = Convert.ToInt32(
                    dgvConsultas.CurrentRow.Cells["ID_Consulta"].Value
                );

                if (cmbCita.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una cita.");
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"UPDATE Med_Consultas
                                SET ID_Cita = @cita,
                                    FechaConsulta = @fecha,
                                    Sintomas = @sintomas,
                                    Diagnostico = @diagnostico,
                                    NotasMedicas = @notas
                                WHERE ID_Consulta = @id";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue(
                        "@cita",
                        cmbCita.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@fecha",
                        dtpFechaConsulta.Value);

                    cmd.Parameters.AddWithValue(
                        "@sintomas",
                        txtSintomas.Text);

                    cmd.Parameters.AddWithValue(
                        "@diagnostico",
                        txtDiagnostico.Text);

                    cmd.Parameters.AddWithValue(
                        "@notas",
                        txtNotasMedicas.Text);

                    cmd.Parameters.AddWithValue("@id", idConsulta);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Consulta modificada correctamente.");

                    CargarConsultas();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar consulta: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvConsultas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una consulta.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar esta consulta?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    int idConsulta = Convert.ToInt32(
                        dgvConsultas.CurrentRow.Cells["ID_Consulta"].Value
                    );

                    Conexion conexion = new Conexion();

                    using (SqlConnection cn = conexion.ObtenerConexion())
                    {
                        cn.Open();

                        string consulta =
                            "DELETE FROM Med_Consultas WHERE ID_Consulta = @id";

                        SqlCommand cmd = new SqlCommand(consulta, cn);

                        cmd.Parameters.AddWithValue("@id", idConsulta);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Consulta eliminada correctamente.");

                        CargarConsultas();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar consulta: " + ex.Message);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
