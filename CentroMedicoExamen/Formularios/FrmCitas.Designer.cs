namespace CentroMedicoExamen.Formularios
{
    partial class FrmCitas
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
            lblPaciente = new Label();
            cmbPaciente = new ComboBox();
            lblMedico = new Label();
            cmbMedico = new ComboBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            lblFechaHora = new Label();
            dtpFechaHora = new DateTimePicker();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvCitas = new DataGridView();
            pnlEncabezdo = new Panel();
            lblSibtitulo = new Label();
            lblIcono = new Label();
            label1 = new Label();
            pnlDatos = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            pnlEncabezdo.SuspendLayout();
            pnlDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BackColor = Color.White;
            lblPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaciente.ForeColor = Color.MidnightBlue;
            lblPaciente.Location = new Point(7, 17);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(72, 20);
            lblPaciente.TabIndex = 0;
            lblPaciente.Text = "Paciente:";
            // 
            // cmbPaciente
            // 
            cmbPaciente.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPaciente.FormattingEnabled = true;
            cmbPaciente.Location = new Point(85, 14);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(142, 31);
            cmbPaciente.TabIndex = 1;
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedico.ForeColor = Color.MidnightBlue;
            lblMedico.Location = new Point(242, 17);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(64, 20);
            lblMedico.TabIndex = 2;
            lblMedico.Text = "Medico:";
            // 
            // cmbMedico
            // 
            cmbMedico.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(310, 14);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(142, 31);
            cmbMedico.TabIndex = 3;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.MidnightBlue;
            lblEstado.Location = new Point(480, 17);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(60, 20);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(543, 14);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(142, 28);
            cmbEstado.TabIndex = 5;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaHora.ForeColor = Color.MidnightBlue;
            lblFechaHora.Location = new Point(703, 17);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(103, 20);
            lblFechaHora.TabIndex = 6;
            lblFechaHora.Text = "Fecha y Hora:";
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.CustomFormat = "dd/MM/yyyy HH : mm";
            dtpFechaHora.Format = DateTimePickerFormat.Custom;
            dtpFechaHora.Location = new Point(829, 15);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.ShowUpDown = true;
            dtpFechaHora.Size = new Size(241, 27);
            dtpFechaHora.TabIndex = 7;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMotivo.ForeColor = Color.MidnightBlue;
            lblMotivo.Location = new Point(169, 65);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(63, 20);
            lblMotivo.TabIndex = 8;
            lblMotivo.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMotivo.Location = new Point(242, 65);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(241, 30);
            txtMotivo.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(559, 64);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(85, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SteelBlue;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(683, 64);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 29);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SteelBlue;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(814, 64);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 29);
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
            btnLimpiar.Location = new Point(937, 65);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(85, 29);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvCitas
            // 
            dgvCitas.BackgroundColor = Color.White;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.GridColor = SystemColors.InactiveCaption;
            dgvCitas.Location = new Point(-12, 210);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.RowHeadersWidth = 51;
            dgvCitas.Size = new Size(1194, 407);
            dgvCitas.TabIndex = 14;
            dgvCitas.CellClick += dgvCitas_CellClick;
            dgvCitas.CellContentClick += dgvCitas_CellContentClick;
            // 
            // pnlEncabezdo
            // 
            pnlEncabezdo.BackColor = Color.MidnightBlue;
            pnlEncabezdo.Controls.Add(lblSibtitulo);
            pnlEncabezdo.Controls.Add(lblIcono);
            pnlEncabezdo.Controls.Add(label1);
            pnlEncabezdo.Dock = DockStyle.Top;
            pnlEncabezdo.Location = new Point(0, 0);
            pnlEncabezdo.Name = "pnlEncabezdo";
            pnlEncabezdo.Size = new Size(1181, 100);
            pnlEncabezdo.TabIndex = 15;
            // 
            // lblSibtitulo
            // 
            lblSibtitulo.AutoSize = true;
            lblSibtitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSibtitulo.ForeColor = Color.Gainsboro;
            lblSibtitulo.Location = new Point(416, 54);
            lblSibtitulo.Name = "lblSibtitulo";
            lblSibtitulo.Size = new Size(345, 20);
            lblSibtitulo.TabIndex = 18;
            lblSibtitulo.Text = "Programación y administración de citas médicas";
            // 
            // lblIcono
            // 
            lblIcono.AutoSize = true;
            lblIcono.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIcono.ForeColor = Color.White;
            lblIcono.Location = new Point(383, -8);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(69, 62);
            lblIcono.TabIndex = 17;
            lblIcono.Text = "✚";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(451, 0);
            label1.Name = "label1";
            label1.Size = new Size(292, 41);
            label1.TabIndex = 16;
            label1.Text = "GESTIÓN DE CITAS ";
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.White;
            pnlDatos.Controls.Add(lblPaciente);
            pnlDatos.Controls.Add(cmbPaciente);
            pnlDatos.Controls.Add(lblMedico);
            pnlDatos.Controls.Add(btnLimpiar);
            pnlDatos.Controls.Add(cmbMedico);
            pnlDatos.Controls.Add(btnModificar);
            pnlDatos.Controls.Add(btnEliminar);
            pnlDatos.Controls.Add(lblEstado);
            pnlDatos.Controls.Add(cmbEstado);
            pnlDatos.Controls.Add(btnGuardar);
            pnlDatos.Controls.Add(lblFechaHora);
            pnlDatos.Controls.Add(txtMotivo);
            pnlDatos.Controls.Add(dtpFechaHora);
            pnlDatos.Controls.Add(lblMotivo);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 100);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1181, 110);
            pnlDatos.TabIndex = 19;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1181, 604);
            Controls.Add(pnlDatos);
            Controls.Add(pnlEncabezdo);
            Controls.Add(dgvCitas);
            Name = "FrmCitas";
            Text = "Gestion de Citas ";
            Load += FrmCitas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            pnlEncabezdo.ResumeLayout(false);
            pnlEncabezdo.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPaciente;
        private ComboBox cmbPaciente;
        private Label lblMedico;
        private ComboBox cmbMedico;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Label lblFechaHora;
        private DateTimePicker dtpFechaHora;
        private Label lblMotivo;
        private TextBox txtMotivo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvCitas;
        private Panel pnlEncabezdo;
        private Label lblIcono;
        private Label label1;
        private Label lblSibtitulo;
        private Panel pnlDatos;
    }
}