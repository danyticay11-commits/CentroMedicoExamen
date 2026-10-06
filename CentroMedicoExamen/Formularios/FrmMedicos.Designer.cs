namespace CentroMedicoExamen.Formularios
{
    partial class FrmMedicos
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            lblLicencia = new Label();
            txtLicencia = new TextBox();
            lblTelfono = new Label();
            txtTelefono = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            cmbEspecialidad = new ComboBox();
            lblEspecialidad = new Label();
            btnGuardad = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvMedicos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            plnEncabezado = new Panel();
            label3 = new Label();
            plnDatos = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
            plnEncabezado.SuspendLayout();
            plnDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.MidnightBlue;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(85, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 30);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 10F);
            txtApellido.Location = new Point(299, 6);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 30);
            txtApellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = Color.MidnightBlue;
            lblApellido.Location = new Point(221, 13);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lblLicencia
            // 
            lblLicencia.AutoSize = true;
            lblLicencia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicencia.ForeColor = Color.MidnightBlue;
            lblLicencia.Location = new Point(642, 11);
            lblLicencia.Name = "lblLicencia";
            lblLicencia.Size = new Size(64, 20);
            lblLicencia.TabIndex = 4;
            lblLicencia.Text = "Licencia";
            // 
            // txtLicencia
            // 
            txtLicencia.Font = new Font("Segoe UI", 10F);
            txtLicencia.Location = new Point(896, 4);
            txtLicencia.Name = "txtLicencia";
            txtLicencia.Size = new Size(125, 30);
            txtLicencia.TabIndex = 5;
            // 
            // lblTelfono
            // 
            lblTelfono.AutoSize = true;
            lblTelfono.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelfono.ForeColor = Color.MidnightBlue;
            lblTelfono.Location = new Point(435, 14);
            lblTelfono.Name = "lblTelfono";
            lblTelfono.Size = new Size(70, 20);
            lblTelfono.TabIndex = 6;
            lblTelfono.Text = "Telefono";
            lblTelfono.Click += label1_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.Location = new Point(511, 6);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 30);
            txtTelefono.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.MidnightBlue;
            lblEmail.Location = new Point(843, 11);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(712, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 30);
            txtEmail.TabIndex = 9;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.Font = new Font("Segoe UI", 10F);
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(1127, 4);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(151, 31);
            cmbEspecialidad.TabIndex = 10;
            cmbEspecialidad.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEspecialidad.ForeColor = Color.MidnightBlue;
            lblEspecialidad.Location = new Point(1027, 10);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(94, 20);
            lblEspecialidad.TabIndex = 11;
            lblEspecialidad.Text = "Especialidad";
            // 
            // btnGuardad
            // 
            btnGuardad.BackColor = Color.SteelBlue;
            btnGuardad.FlatStyle = FlatStyle.Flat;
            btnGuardad.ForeColor = Color.White;
            btnGuardad.Location = new Point(345, 62);
            btnGuardad.Name = "btnGuardad";
            btnGuardad.Size = new Size(94, 29);
            btnGuardad.TabIndex = 12;
            btnGuardad.Text = "Guardar";
            btnGuardad.UseVisualStyleBackColor = false;
            btnGuardad.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.DarkOrange;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(461, 62);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(581, 62);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DimGray;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(702, 62);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += button4_Click;
            // 
            // dgvMedicos
            // 
            dgvMedicos.AllowUserToAddRows = false;
            dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicos.BackgroundColor = Color.White;
            dgvMedicos.BorderStyle = BorderStyle.None;
            dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicos.Location = new Point(-14, 194);
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.ReadOnly = true;
            dgvMedicos.RowHeadersWidth = 51;
            dgvMedicos.Size = new Size(1301, 375);
            dgvMedicos.TabIndex = 16;
            dgvMedicos.CellContentClick += dgvMedicos_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(461, 42);
            label1.Name = "label1";
            label1.Size = new Size(262, 20);
            label1.TabIndex = 18;
            label1.Text = "Registro y administracion de Medicos ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(511, 9);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 19;
            label2.Text = "GESTION DE MEDICOS";
            // 
            // plnEncabezado
            // 
            plnEncabezado.BackColor = Color.MidnightBlue;
            plnEncabezado.Controls.Add(label3);
            plnEncabezado.Controls.Add(label2);
            plnEncabezado.Controls.Add(label1);
            plnEncabezado.Dock = DockStyle.Top;
            plnEncabezado.Location = new Point(0, 0);
            plnEncabezado.Name = "plnEncabezado";
            plnEncabezado.Size = new Size(1287, 75);
            plnEncabezado.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(470, 9);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 20;
            label3.Text = "✚";
            // 
            // plnDatos
            // 
            plnDatos.BackColor = Color.White;
            plnDatos.Controls.Add(lblApellido);
            plnDatos.Controls.Add(txtApellido);
            plnDatos.Controls.Add(lblTelfono);
            plnDatos.Controls.Add(btnLimpiar);
            plnDatos.Controls.Add(txtTelefono);
            plnDatos.Controls.Add(btnEliminar);
            plnDatos.Controls.Add(txtNombre);
            plnDatos.Controls.Add(btnModificar);
            plnDatos.Controls.Add(lblNombre);
            plnDatos.Controls.Add(btnGuardad);
            plnDatos.Controls.Add(lblLicencia);
            plnDatos.Controls.Add(lblEspecialidad);
            plnDatos.Controls.Add(txtLicencia);
            plnDatos.Controls.Add(cmbEspecialidad);
            plnDatos.Controls.Add(lblEmail);
            plnDatos.Controls.Add(txtEmail);
            plnDatos.Dock = DockStyle.Top;
            plnDatos.Location = new Point(0, 75);
            plnDatos.Name = "plnDatos";
            plnDatos.Size = new Size(1287, 113);
            plnDatos.TabIndex = 21;
            // 
            // FrmMedicos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1287, 706);
            Controls.Add(plnDatos);
            Controls.Add(plnEncabezado);
            Controls.Add(dgvMedicos);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMedicos";
            Text = "Gestion de medicos";
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
            plnEncabezado.ResumeLayout(false);
            plnEncabezado.PerformLayout();
            plnDatos.ResumeLayout(false);
            plnDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label lblLicencia;
        private TextBox txtLicencia;
        private Label lblTelfono;
        private TextBox txtTelefono;
        private Label lblEmail;
        private TextBox txtEmail;
        private ComboBox cmbEspecialidad;
        private Label lblEspecialidad;
        private Button btnGuardad;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvMedicos;
        private Label label1;
        private Label label2;
        private Panel plnEncabezado;
        private Label label3;
        private Panel plnDatos;
    }
}