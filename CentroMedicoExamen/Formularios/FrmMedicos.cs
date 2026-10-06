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
    public partial class FrmMedicos : Form
    {
        public FrmMedicos()
        {
            InitializeComponent();

            CargarEspecialidades();
            CargarMedicos();
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
                                M.Nombre,
                                M.Apellido,
                                M.LicenciaMedica,
                                M.Telefono,
                                M.Email,
                                E.NombreEspecialidad
                                FROM Med_Medicos M
                                INNER JOIN Med_Especialidades E
                                ON M.ID_Especialidad = E.ID_Especialidad";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgvMedicos.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar médicos: " + ex.Message);
            }
        }


        private void CargarEspecialidades()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"SELECT ID_Especialidad, NombreEspecialidad
                                FROM Med_Especialidades";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    cmbEspecialidad.DataSource = tabla;
                    cmbEspecialidad.DisplayMember = "NombreEspecialidad";
                    cmbEspecialidad.ValueMember = "ID_Especialidad";
                    cmbEspecialidad.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar especialidades: " + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEspecialidad.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una especialidad.");
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"INSERT INTO Med_Medicos
                                (ID_Especialidad, Nombre, Apellido,
                                 LicenciaMedica, Telefono, Email)
                                VALUES
                                (@especialidad, @nombre, @apellido,
                                 @licencia, @telefono, @email)";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue(
                        "@especialidad",
                        cmbEspecialidad.SelectedValue);

                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@licencia", txtLicencia.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Médico guardado correctamente.");

                    CargarMedicos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar médico: " + ex.Message);
            }

        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtLicencia.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();

            cmbEspecialidad.SelectedIndex = -1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un médico.");
                return;
            }

            try
            {
                int idMedico = Convert.ToInt32(
                    dgvMedicos.CurrentRow.Cells["ID_Medico"].Value
                );

                if (cmbEspecialidad.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una especialidad.");
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"UPDATE Med_Medicos
                                SET ID_Especialidad = @especialidad,
                                    Nombre = @nombre,
                                    Apellido = @apellido,
                                    LicenciaMedica = @licencia,
                                    Telefono = @telefono,
                                    Email = @email
                                WHERE ID_Medico = @id";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue(
                        "@especialidad", cmbEspecialidad.SelectedValue);

                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@licencia", txtLicencia.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@id", idMedico);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Médico modificado correctamente.");

                    CargarMedicos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar médico: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un médico.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar este médico?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    int idMedico = Convert.ToInt32(
                        dgvMedicos.CurrentRow.Cells["ID_Medico"].Value
                    );

                    Conexion conexion = new Conexion();

                    using (SqlConnection cn = conexion.ObtenerConexion())
                    {
                        cn.Open();

                        string consulta =
                            "DELETE FROM Med_Medicos WHERE ID_Medico = @id";

                        SqlCommand cmd = new SqlCommand(consulta, cn);

                        cmd.Parameters.AddWithValue("@id", idMedico);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Médico eliminado correctamente.");

                        CargarMedicos();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar médico: " + ex.Message);
                }
            }
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
