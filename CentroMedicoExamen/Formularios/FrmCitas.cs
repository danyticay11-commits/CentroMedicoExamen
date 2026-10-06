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
using System.Drawing.Text;

namespace CentroMedicoExamen.Formularios
{
    public partial class FrmCitas : Form
    {
        public FrmCitas()
        {
            InitializeComponent();

            CargarPacientes();
            CargarMedicos();
            CargarEstados();
            CargarCitas();

        }

        private void CargarPacientes()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"SELECT 
                                ID_Paciente,
                                Nombre + ' ' + Apellido AS NombreCompleto
                                FROM Med_Pacientes";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    cmbPaciente.DataSource = tabla;
                    cmbPaciente.DisplayMember = "NombreCompleto";
                    cmbPaciente.ValueMember = "ID_Paciente";
                    cmbPaciente.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message);
            }
        }

        private void CargarMedicos()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"SELECT 
                                M.ID_Medico,
                                M.Nombre + ' ' + M.Apellido 
                                + ' - ' + E.NombreEspecialidad AS NombreCompleto
                                FROM Med_Medicos M
                                INNER JOIN Med_Especialidades E
                                ON M.ID_Especialidad = E.ID_Especialidad";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    cmbMedico.DataSource = tabla;
                    cmbMedico.DisplayMember = "NombreCompleto";
                    cmbMedico.ValueMember = "ID_Medico";
                    cmbMedico.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar médicos: " + ex.Message);
            }
        }

        private void CargarEstados()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"SELECT 
                                ID_EstadoCita,
                                Estado
                                FROM Med_EstadosCita";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    cmbEstado.DataSource = tabla;
                    cmbEstado.DisplayMember = "Estado";
                    cmbEstado.ValueMember = "ID_EstadoCita";
                    cmbEstado.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estados: " + ex.Message);
            }
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
                                C.ID_Paciente,
                                P.Nombre + ' ' + P.Apellido AS Paciente,
                                C.ID_Medico,
                                M.Nombre + ' ' + M.Apellido AS Medico,
                                C.ID_EstadoCita,
                                EC.Estado,
                                C.FechaHora,
                                C.Motivo
                                FROM Med_Citas C
                                INNER JOIN Med_Pacientes P
                                ON C.ID_Paciente = P.ID_Paciente
                                INNER JOIN Med_Medicos M
                                ON C.ID_Medico = M.ID_Medico
                                INNER JOIN Med_EstadosCita EC
                                ON C.ID_EstadoCita = EC.ID_EstadoCita";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgvCitas.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message);
            }
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPaciente.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione a un paciente.");
                    return;
                }

                if (cmbMedico.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione a un médico.");
                    return;
                }

                if (cmbEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un estado.");
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"INSERT INTO Med_Citas
                                (ID_Paciente, ID_Medico, ID_EstadoCita,
                                 FechaHora, Motivo)
                                VALUES
                                (@paciente, @medico, @estado,
                                 @fecha, @motivo)";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue(
                        "@paciente",
                        cmbPaciente.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@medico",
                        cmbMedico.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@estado",
                        cmbEstado.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@fecha",
                        dtpFechaHora.Value);

                    cmd.Parameters.AddWithValue(
                        "@motivo",
                        txtMotivo.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Su cita fue guardada correctamente.");

                    CargarCitas();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar su cita: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            cmbPaciente.SelectedIndex = -1;
            cmbMedico.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

            dtpFechaHora.Value = DateTime.Now;

            txtMotivo.Clear();
        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCitas.Rows[e.RowIndex];

                cmbPaciente.SelectedValue =
                    fila.Cells["ID_Paciente"].Value;

                cmbMedico.SelectedValue =
                    fila.Cells["ID_Medico"].Value;

                cmbEstado.SelectedValue =
                    fila.Cells["ID_EstadoCita"].Value;

                if (fila.Cells["FechaHora"].Value != DBNull.Value)
                {
                    dtpFechaHora.Value =
                        Convert.ToDateTime(fila.Cells["FechaHora"].Value);
                }

                txtMotivo.Text =
                    fila.Cells["Motivo"].Value?.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cita.");
                return;
            }

            try
            {
                int idCita = Convert.ToInt32(
                    dgvCitas.CurrentRow.Cells["ID_Cita"].Value
                );

                if (cmbPaciente.SelectedIndex == -1 ||
                    cmbMedico.SelectedIndex == -1 ||
                    cmbEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Complete los datos de la cita por favot.");
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"UPDATE Med_Citas
                                SET ID_Paciente = @paciente,
                                    ID_Medico = @medico,
                                    ID_EstadoCita = @estado,
                                    FechaHora = @fecha,
                                    Motivo = @motivo
                                WHERE ID_Cita = @id";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue(
                        "@paciente",
                        cmbPaciente.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@medico",
                        cmbMedico.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@estado",
                        cmbEstado.SelectedValue);

                    cmd.Parameters.AddWithValue(
                        "@fecha",
                        dtpFechaHora.Value);

                    cmd.Parameters.AddWithValue(
                        "@motivo",
                        txtMotivo.Text);

                    cmd.Parameters.AddWithValue("@id", idCita);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("La cita fue modificada correctamente.");

                    CargarCitas();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar su cita: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cita.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar esta cita... 🫡?",
                "Confirmar la eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    int idCita = Convert.ToInt32(
                        dgvCitas.CurrentRow.Cells["ID de la Cita"].Value
                    );

                    Conexion conexion = new Conexion();

                    using (SqlConnection cn = conexion.ObtenerConexion())
                    {
                        cn.Open();

                        string consulta =
                            "DELETE FROM Med_Citas WHERE ID_Cita = @id";

                        SqlCommand cmd = new SqlCommand(consulta, cn);

                        cmd.Parameters.AddWithValue("@id", idCita);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("La cita eliminada correctamente.");

                        CargarCitas();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar su cita: " + ex.Message);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
