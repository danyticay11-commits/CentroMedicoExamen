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
    public partial class FrmMedicamentos : Form
    {
        public FrmMedicamentos()
        {
            InitializeComponent();

            CargarMedicamentos();
        }

        private void CargarMedicamentos()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"SELECT 
                                ID_Medicamento,
                                NombreMedicamento,
                                Presentacion,
                                Stock
                                FROM Med_Medicamentos";

                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgvMedicamentos.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar la tabla de Medicamentos: " + ex.Message);
            }
        }

        private void FrmMedicamentos_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreMedicamento.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el nombre del medicamento.");
                    return;
                }

                if (txtStock.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el stock.");
                    return;
                }

                int stock;

                if (!int.TryParse(txtStock.Text, out stock))
                {
                    MessageBox.Show("El stock debe ser un número.");
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"INSERT INTO Med_Medicamentos
                                (NombreMedicamento, Presentacion, Stock)
                                VALUES
                                (@nombre, @presentacion, @stock)";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue(
                        "@nombre",
                        txtNombreMedicamento.Text);

                    cmd.Parameters.AddWithValue(
                        "@presentacion",
                        txtPresentacion.Text);

                    cmd.Parameters.AddWithValue(
                        "@stock",
                        stock);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Medicamento guardado correctamente.");

                    CargarMedicamentos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar medicamento: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombreMedicamento.Clear();
            txtPresentacion.Clear();
            txtStock.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un medicamento.");
                return;
            }

            try
            {
                int idMedicamento = Convert.ToInt32(
                    dgvMedicamentos.CurrentRow
                        .Cells["ID_Medicamento"].Value
                );

                if (txtNombreMedicamento.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el nombre del medicamento.");
                    return;
                }

                int stock;

                if (!int.TryParse(txtStock.Text, out stock))
                {
                    MessageBox.Show("El stock debe ser un número.");
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"UPDATE Med_Medicamentos
                                SET NombreMedicamento = @nombre,
                                    Presentacion = @presentacion,
                                    Stock = @stock
                                WHERE ID_Medicamento = @id";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue(
                        "@nombre",
                        txtNombreMedicamento.Text);

                    cmd.Parameters.AddWithValue(
                        "@presentacion",
                        txtPresentacion.Text);

                    cmd.Parameters.AddWithValue(
                        "@stock",
                        stock);

                    cmd.Parameters.AddWithValue(
                        "@id",
                        idMedicamento);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Medicamento modificado correctamente.");

                    CargarMedicamentos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar medicamento: " + ex.Message);
            }
        }

        private void dgvMedicamentos_CellClick(
       object sender,
       DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dgvMedicamentos.Rows[e.RowIndex];

                txtNombreMedicamento.Text =
                    fila.Cells["NombreMedicamento"]
                        .Value?.ToString();

                txtPresentacion.Text =
                    fila.Cells["Presentacion"]
                        .Value?.ToString();

                txtStock.Text =
                    fila.Cells["Stock"]
                        .Value?.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un medicamento.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar este medicamento?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    int idMedicamento = Convert.ToInt32(
                        dgvMedicamentos.CurrentRow
                            .Cells["ID_Medicamento"].Value
                    );

                    Conexion conexion = new Conexion();

                    using (SqlConnection cn = conexion.ObtenerConexion())
                    {
                        cn.Open();

                        string consulta =
                            "DELETE FROM Med_Medicamentos " +
                            "WHERE ID_Medicamento = @id";

                        SqlCommand cmd =
                            new SqlCommand(consulta, cn);

                        cmd.Parameters.AddWithValue(
                            "@id",
                            idMedicamento);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show(
                            "Medicamento eliminado correctamente.");

                        CargarMedicamentos();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al eliminar medicamento: " +
                        ex.Message);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnLimpiar_CommandParameterChanged(object sender, EventArgs e)
        {

        }

        private void lblPresentacion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
