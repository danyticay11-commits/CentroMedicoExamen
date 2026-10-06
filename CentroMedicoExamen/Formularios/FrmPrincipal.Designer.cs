namespace CentroMedicoExamen.Formularios
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTituloPrincipal = new Label();
            btnPacientes = new Button();
            btnMedicos = new Button();
            btnCitas = new Button();
            btnConsultas = new Button();
            btnMedicamentos = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPrincipal.ForeColor = SystemColors.MenuHighlight;
            lblTituloPrincipal.Location = new Point(56, 9);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(281, 41);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = " CENTRO MEDICO ";
            // 
            // btnPacientes
            // 
            btnPacientes.BackColor = Color.SteelBlue;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPacientes.ForeColor = Color.White;
            btnPacientes.Location = new Point(24, 81);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(150, 50);
            btnPacientes.TabIndex = 1;
            btnPacientes.Text = "Pacientes";
            btnPacientes.UseVisualStyleBackColor = false;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // btnMedicos
            // 
            btnMedicos.BackColor = Color.SteelBlue;
            btnMedicos.FlatStyle = FlatStyle.Flat;
            btnMedicos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMedicos.ForeColor = SystemColors.ControlLightLight;
            btnMedicos.Location = new Point(208, 81);
            btnMedicos.Name = "btnMedicos";
            btnMedicos.Size = new Size(150, 50);
            btnMedicos.TabIndex = 2;
            btnMedicos.Text = "Medicos ";
            btnMedicos.UseVisualStyleBackColor = false;
            btnMedicos.Click += btnMedicos_Click;
            // 
            // btnCitas
            // 
            btnCitas.BackColor = Color.SteelBlue;
            btnCitas.FlatStyle = FlatStyle.Flat;
            btnCitas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCitas.ForeColor = SystemColors.ControlLightLight;
            btnCitas.Location = new Point(24, 154);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(150, 50);
            btnCitas.TabIndex = 3;
            btnCitas.Text = "Citas";
            btnCitas.UseVisualStyleBackColor = false;
            btnCitas.Click += btnCitas_Click;
            // 
            // btnConsultas
            // 
            btnConsultas.BackColor = Color.SteelBlue;
            btnConsultas.FlatStyle = FlatStyle.Flat;
            btnConsultas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultas.ForeColor = SystemColors.ControlLightLight;
            btnConsultas.Location = new Point(208, 154);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Size = new Size(150, 50);
            btnConsultas.TabIndex = 4;
            btnConsultas.Text = "Consultas";
            btnConsultas.UseVisualStyleBackColor = false;
            btnConsultas.Click += btnConsultas_Click;
            // 
            // btnMedicamentos
            // 
            btnMedicamentos.BackColor = Color.SteelBlue;
            btnMedicamentos.FlatStyle = FlatStyle.Flat;
            btnMedicamentos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMedicamentos.ForeColor = Color.White;
            btnMedicamentos.Location = new Point(115, 221);
            btnMedicamentos.Name = "btnMedicamentos";
            btnMedicamentos.Size = new Size(150, 50);
            btnMedicamentos.TabIndex = 5;
            btnMedicamentos.Text = "Medicamentos ";
            btnMedicamentos.UseVisualStyleBackColor = false;
            btnMedicamentos.Click += btnMedicamentos_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.IndianRed;
            btnCerrarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(115, 296);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(150, 40);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(393, 370);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnMedicamentos);
            Controls.Add(btnConsultas);
            Controls.Add(btnCitas);
            Controls.Add(btnMedicos);
            Controls.Add(btnPacientes);
            Controls.Add(lblTituloPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Centro medico - Sistema de Gestion ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloPrincipal;
        private Button btnPacientes;
        private Button btnMedicos;
        private Button btnCitas;
        private Button btnConsultas;
        private Button btnMedicamentos;
        private Button btnCerrarSesion;
    }
}