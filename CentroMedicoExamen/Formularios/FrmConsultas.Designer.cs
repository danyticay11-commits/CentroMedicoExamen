namespace CentroMedicoExamen.Formularios
{
    partial class FrmConsultas
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
            lblCita = new Label();
            cmbCita = new ComboBox();
            lblFechaConsulta = new Label();
            dtpFechaConsulta = new DateTimePicker();
            lblSintomas = new Label();
            txtSintomas = new TextBox();
            lblDiagnostico = new Label();
            txtDiagnostico = new TextBox();
            lblNotasMedicas = new Label();
            txtNotasMedicas = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvConsultas = new DataGridView();
            panel1 = new Panel();
            lblTitulo = new Label();
            label1 = new Label();
            lblIcono = new Label();
            pnlDatos = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
            panel1.SuspendLayout();
            pnlDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblCita
            // 
            lblCita.AutoSize = true;
            lblCita.FlatStyle = FlatStyle.Flat;
            lblCita.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCita.ForeColor = Color.MidnightBlue;
            lblCita.Location = new Point(24, 18);
            lblCita.Name = "lblCita";
            lblCita.Size = new Size(40, 20);
            lblCita.TabIndex = 0;
            lblCita.Text = "Cita:";
            // 
            // cmbCita
            // 
            cmbCita.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCita.FormattingEnabled = true;
            cmbCita.Location = new Point(77, 18);
            cmbCita.Name = "cmbCita";
            cmbCita.Size = new Size(151, 31);
            cmbCita.TabIndex = 1;
            // 
            // lblFechaConsulta
            // 
            lblFechaConsulta.AutoSize = true;
            lblFechaConsulta.BackColor = Color.White;
            lblFechaConsulta.FlatStyle = FlatStyle.Flat;
            lblFechaConsulta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaConsulta.ForeColor = Color.MidnightBlue;
            lblFechaConsulta.Location = new Point(246, 18);
            lblFechaConsulta.Name = "lblFechaConsulta";
            lblFechaConsulta.Size = new Size(156, 23);
            lblFechaConsulta.TabIndex = 2;
            lblFechaConsulta.Text = "Fecha de consulta ";
            lblFechaConsulta.Click += lblFechaConsulta_Click;
            // 
            // dtpFechaConsulta
            // 
            dtpFechaConsulta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaConsulta.Location = new Point(408, 18);
            dtpFechaConsulta.Name = "dtpFechaConsulta";
            dtpFechaConsulta.Size = new Size(250, 27);
            dtpFechaConsulta.TabIndex = 3;
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.BackColor = Color.White;
            lblSintomas.FlatStyle = FlatStyle.Flat;
            lblSintomas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSintomas.ForeColor = Color.MidnightBlue;
            lblSintomas.Location = new Point(12, 81);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new Size(78, 20);
            lblSintomas.TabIndex = 4;
            lblSintomas.Text = "Sintomas ";
            // 
            // txtSintomas
            // 
            txtSintomas.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSintomas.Location = new Point(96, 55);
            txtSintomas.Multiline = true;
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(298, 73);
            txtSintomas.TabIndex = 5;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.FlatStyle = FlatStyle.Flat;
            lblDiagnostico.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagnostico.ForeColor = Color.MidnightBlue;
            lblDiagnostico.Location = new Point(431, 81);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(96, 20);
            lblDiagnostico.TabIndex = 6;
            lblDiagnostico.Text = "Diagnostico:";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(533, 51);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(280, 78);
            txtDiagnostico.TabIndex = 7;
            // 
            // lblNotasMedicas
            // 
            lblNotasMedicas.AutoSize = true;
            lblNotasMedicas.FlatStyle = FlatStyle.Flat;
            lblNotasMedicas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotasMedicas.ForeColor = Color.MidnightBlue;
            lblNotasMedicas.Location = new Point(844, 81);
            lblNotasMedicas.Name = "lblNotasMedicas";
            lblNotasMedicas.RightToLeft = RightToLeft.No;
            lblNotasMedicas.Size = new Size(116, 20);
            lblNotasMedicas.TabIndex = 8;
            lblNotasMedicas.Text = "Notas Medicas:";
            // 
            // txtNotasMedicas
            // 
            txtNotasMedicas.Location = new Point(960, 44);
            txtNotasMedicas.Multiline = true;
            txtNotasMedicas.Name = "txtNotasMedicas";
            txtNotasMedicas.Size = new Size(262, 85);
            txtNotasMedicas.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(745, 9);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar ";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SteelBlue;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(866, 9);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar ";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SteelBlue;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(982, 9);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.SteelBlue;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(1094, 9);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvConsultas
            // 
            dgvConsultas.BackgroundColor = Color.White;
            dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultas.Location = new Point(0, 259);
            dgvConsultas.Name = "dgvConsultas";
            dgvConsultas.RowHeadersWidth = 51;
            dgvConsultas.Size = new Size(1222, 417);
            dgvConsultas.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(lblIcono);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1227, 110);
            panel1.TabIndex = 15;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(389, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(486, 62);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Consultas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(408, 75);
            label1.Name = "label1";
            label1.Size = new Size(429, 23);
            label1.TabIndex = 1;
            label1.Text = "Programación y administracion de cada Consulta ";
            // 
            // lblIcono
            // 
            lblIcono.AutoSize = true;
            lblIcono.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIcono.ForeColor = Color.White;
            lblIcono.Location = new Point(325, 9);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(69, 62);
            lblIcono.TabIndex = 18;
            lblIcono.Text = "✚";
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.White;
            pnlDatos.Controls.Add(lblCita);
            pnlDatos.Controls.Add(cmbCita);
            pnlDatos.Controls.Add(lblFechaConsulta);
            pnlDatos.Controls.Add(dtpFechaConsulta);
            pnlDatos.Controls.Add(btnLimpiar);
            pnlDatos.Controls.Add(lblSintomas);
            pnlDatos.Controls.Add(btnEliminar);
            pnlDatos.Controls.Add(txtSintomas);
            pnlDatos.Controls.Add(btnModificar);
            pnlDatos.Controls.Add(lblDiagnostico);
            pnlDatos.Controls.Add(btnGuardar);
            pnlDatos.Controls.Add(txtDiagnostico);
            pnlDatos.Controls.Add(txtNotasMedicas);
            pnlDatos.Controls.Add(lblNotasMedicas);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 110);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1227, 143);
            pnlDatos.TabIndex = 19;
            // 
            // FrmConsultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1227, 675);
            Controls.Add(pnlDatos);
            Controls.Add(panel1);
            Controls.Add(dgvConsultas);
            Name = "FrmConsultas";
            Text = "Gestion de consultas medicas ";
            Load += FrmConsultas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCita;
        private ComboBox cmbCita;
        private Label lblFechaConsulta;
        private DateTimePicker dtpFechaConsulta;
        private Label lblSintomas;
        private TextBox txtSintomas;
        private Label lblDiagnostico;
        private TextBox txtDiagnostico;
        private Label lblNotasMedicas;
        private TextBox txtNotasMedicas;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvConsultas;
        private Panel panel1;
        private Label label1;
        private Label lblTitulo;
        private Label lblIcono;
        private Panel pnlDatos;
    }
}