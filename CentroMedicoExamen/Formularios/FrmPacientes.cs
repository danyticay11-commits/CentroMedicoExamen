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
    public partial class FrmPacientes : Form
    {
        public FrmPacientes()
        {
            InitializeComponent();

            cmbGenero.Items.Add("M");
            cmbGenero.Items.Add("F");
            cmbGenero.Items.Add("O");

            CargarPacientes();

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
                                DNI_Cedula,
                                Nombre,
                                Apellido,
                                FechaNacimiento,
                                Genero,
                                Telefono,
                                Direccion,
                                ContactoEmergencia
                                FROM Med_Pacientes";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dvgPacientes.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message);
            }
        }

        private void dvgPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"INSERT INTO Med_Pacientes
                                (DNI_Cedula, Nombre, Apellido, FechaNacimiento,
                                 Genero, Telefono, Direccion, ContactoEmergencia)
                                VALUES
                                (@dni, @nombre, @apellido, @fecha,
                                 @genero, @telefono, @direccion, @contacto)";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue("@dni", txtDNI.Text);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@fecha", dtpFechaNacimiento.Value);
                    cmd.Parameters.AddWithValue("@genero", cmbGenero.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@contacto", txtContacto.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Paciente guardado correctamente.");

                    CargarPacientes();

                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar paciente: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtContacto.Clear();

            cmbGenero.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Now;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dvgPacientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un paciente.");
                return;
            }

            try
            {
                int idPaciente = Convert.ToInt32(
                    dvgPacientes.CurrentRow.Cells["ID_Paciente"].Value
                );

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"UPDATE Med_Pacientes
                                SET DNI_Cedula = @dni,
                                    Nombre = @nombre,
                                    Apellido = @apellido,
                                    FechaNacimiento = @fecha,
                                    Genero = @genero,
                                    Telefono = @telefono,
                                    Direccion = @direccion,
                                    ContactoEmergencia = @contacto
                                WHERE ID_Paciente = @id";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue("@dni", txtDNI.Text);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@fecha", dtpFechaNacimiento.Value);
                    cmd.Parameters.AddWithValue("@genero", cmbGenero.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@contacto", txtContacto.Text);
                    cmd.Parameters.AddWithValue("@id", idPaciente);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Paciente modificado correctamente.");

                    CargarPacientes();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar paciente: " + ex.Message);
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgPacientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un paciente.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar este paciente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    int idPaciente = Convert.ToInt32(
                        dvgPacientes.CurrentRow.Cells["ID_Paciente"].Value
                    );

                    Conexion conexion = new Conexion();

                    using (SqlConnection cn = conexion.ObtenerConexion())
                    {
                        cn.Open();

                        string consulta =
                            "DELETE FROM Med_Pacientes WHERE ID_Paciente = @id";

                        SqlCommand cmd = new SqlCommand(consulta, cn);

                        cmd.Parameters.AddWithValue("@id", idPaciente);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Paciente eliminado correctamente.");

                        CargarPacientes();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar paciente: " + ex.Message);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
