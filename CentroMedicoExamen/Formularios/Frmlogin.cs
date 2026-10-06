using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CentroMedicoExamen.Datos;

namespace CentroMedicoExamen.Formularios
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"SELECT U.ID_Usuario, U.Username, R.NombreRol
                                FROM Med_Usuarios U
                                INNER JOIN Med_Roles R
                                ON U.ID_Rol = R.ID_Rol
                                WHERE U.Username = @usuario
                                AND U.Contrasena = @contrasena
                                AND U.Estado = 1";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@contrasena", txtContraseña.Text);

                    SqlDataReader lector = cmd.ExecuteReader();

                    if (lector.Read())
                    {
                        string nombreRol = lector["NombreRol"].ToString();

                        MessageBox.Show("Bienvenido " + txtUsuario.Text);

                        FrmPrincipal principal = new FrmPrincipal();
                        principal.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
