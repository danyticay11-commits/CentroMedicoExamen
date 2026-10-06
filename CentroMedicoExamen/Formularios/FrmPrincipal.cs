using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CentroMedicoExamen.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Frmlogin login = new Frmlogin();
            login.Show();

            this.Close();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            FrmPacientes pacientes = new FrmPacientes();
            pacientes.ShowDialog();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            FrmMedicos medicos = new FrmMedicos();
            medicos.ShowDialog();

        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FrmCitas citas = new FrmCitas();

            citas.ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FrmConsultas consultas = new FrmConsultas();

            consultas.ShowDialog();
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            FrmMedicamentos medicamentos =
                new FrmMedicamentos();

            medicamentos.ShowDialog();
        }
    }
}
