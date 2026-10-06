namespace CentroMedicoExamen.Formularios
{
    partial class FrmPacientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblDNI = new Label();
            txtDNI = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblGenero = new Label();
            cmbGenero = new ComboBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblContacto = new Label();
            txtContacto = new TextBox();
            dvgPacientes = new DataGridView();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            pnlDatos = new Panel();
            plnEncabezado = new Panel();
            lblTitulo = new Label();
            LBLSubtitulo = new Label();
            lblIcono = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgPacientes).BeginInit();
            pnlDatos.SuspendLayout();
            plnEncabezado.SuspendLayout();
            SuspendLayout();
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDNI.ForeColor = Color.MidnightBlue;
            lblDNI.Location = new Point(12, 11);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(91, 20);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI/Cedula";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = Color.White;
            txtDNI.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDNI.Location = new Point(109, 9);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(125, 30);
            txtDNI.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.MidnightBlue;
            lblNombre.Location = new Point(259, 12);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(332, 8);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 30);
            txtNombre.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = Color.MidnightBlue;
            lblApellido.Location = new Point(491, 12);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 20);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.White;
            txtApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(564, 9);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 30);
            txtApellido.TabIndex = 5;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaNacimiento.ForeColor = Color.MidnightBlue;
            lblFechaNacimiento.Location = new Point(717, 15);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(159, 20);
            lblFechaNacimiento.TabIndex = 6;
            lblFechaNacimiento.Text = "Fecha de Nacimiento ";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(882, 8);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(144, 30);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenero.ForeColor = Color.MidnightBlue;
            lblGenero.Location = new Point(24, 58);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(60, 20);
            lblGenero.TabIndex = 8;
            lblGenero.Text = "Genero";
            // 
            // cmbGenero
            // 
            cmbGenero.BackColor = Color.White;
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(90, 52);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(151, 31);
            cmbGenero.TabIndex = 9;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.GhostWhite;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = Color.MidnightBlue;
            lblTelefono.Location = new Point(256, 58);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 10;
            lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(332, 55);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 30);
            txtTelefono.TabIndex = 11;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.ForeColor = Color.MidnightBlue;
            lblDireccion.Location = new Point(484, 58);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(74, 20);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.White;
            txtDireccion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(564, 55);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 30);
            txtDireccion.TabIndex = 13;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContacto.ForeColor = Color.MidnightBlue;
            lblContacto.Location = new Point(717, 55);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(178, 20);
            lblContacto.TabIndex = 14;
            lblContacto.Text = "Contacto de Emergencia";
            // 
            // txtContacto
            // 
            txtContacto.BackColor = Color.White;
            txtContacto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContacto.Location = new Point(901, 48);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(125, 30);
            txtContacto.TabIndex = 15;
            // 
            // dvgPacientes
            // 
            dvgPacientes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dvgPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dvgPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgPacientes.BackgroundColor = Color.White;
            dvgPacientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dvgPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dvgPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgPacientes.GridColor = Color.Black;
            dvgPacientes.Location = new Point(0, 220);
            dvgPacientes.Name = "dvgPacientes";
            dvgPacientes.ReadOnly = true;
            dvgPacientes.RowHeadersVisible = false;
            dvgPacientes.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dvgPacientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dvgPacientes.Size = new Size(1382, 458);
            dvgPacientes.TabIndex = 16;
            dvgPacientes.CellClick += dgvPacientes_CellClick;
            dvgPacientes.CellContentClick += dvgPacientes_CellContentClick;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(1112, 9);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 17;
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
            btnModificar.Location = new Point(1112, 52);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 18;
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
            btnEliminar.Location = new Point(1245, 7);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 19;
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
            btnLimpiar.Location = new Point(1245, 51);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.White;
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Controls.Add(btnLimpiar);
            pnlDatos.Controls.Add(lblDNI);
            pnlDatos.Controls.Add(btnModificar);
            pnlDatos.Controls.Add(btnEliminar);
            pnlDatos.Controls.Add(txtDNI);
            pnlDatos.Controls.Add(txtNombre);
            pnlDatos.Controls.Add(btnGuardar);
            pnlDatos.Controls.Add(lblApellido);
            pnlDatos.Controls.Add(txtApellido);
            pnlDatos.Controls.Add(txtContacto);
            pnlDatos.Controls.Add(lblFechaNacimiento);
            pnlDatos.Controls.Add(lblContacto);
            pnlDatos.Controls.Add(dtpFechaNacimiento);
            pnlDatos.Controls.Add(txtDireccion);
            pnlDatos.Controls.Add(cmbGenero);
            pnlDatos.Controls.Add(lblDireccion);
            pnlDatos.Controls.Add(lblGenero);
            pnlDatos.Controls.Add(txtTelefono);
            pnlDatos.Controls.Add(lblTelefono);
            pnlDatos.Location = new Point(0, 108);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1379, 106);
            pnlDatos.TabIndex = 21;
            // 
            // plnEncabezado
            // 
            plnEncabezado.BackColor = Color.MidnightBlue;
            plnEncabezado.Controls.Add(lblIcono);
            plnEncabezado.Controls.Add(LBLSubtitulo);
            plnEncabezado.Controls.Add(lblTitulo);
            plnEncabezado.Dock = DockStyle.Top;
            plnEncabezado.Location = new Point(0, 0);
            plnEncabezado.Name = "plnEncabezado";
            plnEncabezado.Size = new Size(1377, 102);
            plnEncabezado.TabIndex = 22;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(563, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(335, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE PACIENTES";
            // 
            // LBLSubtitulo
            // 
            LBLSubtitulo.AutoSize = true;
            LBLSubtitulo.BackColor = Color.MidnightBlue;
            LBLSubtitulo.ForeColor = Color.Gainsboro;
            LBLSubtitulo.Location = new Point(592, 63);
            LBLSubtitulo.Name = "LBLSubtitulo";
            LBLSubtitulo.Size = new Size(265, 20);
            LBLSubtitulo.TabIndex = 1;
            LBLSubtitulo.Text = "Registro y Administracion de Pacientes";
            // 
            // lblIcono
            // 
            lblIcono.AutoSize = true;
            lblIcono.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIcono.ForeColor = SystemColors.Control;
            lblIcono.Location = new Point(499, 0);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(69, 62);
            lblIcono.TabIndex = 2;
            lblIcono.Text = "✚";
            // 
            // FrmPacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1377, 690);
            Controls.Add(plnEncabezado);
            Controls.Add(pnlDatos);
            Controls.Add(dvgPacientes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmPacientes";
            Text = "GESTION DE PACIENTES";
            Load += FrmPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)dvgPacientes).EndInit();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            plnEncabezado.ResumeLayout(false);
            plnEncabezado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDNI;
        private TextBox txtDNI;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblGenero;
        private ComboBox cmbGenero;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblContacto;
        private TextBox txtContacto;
        private DataGridView dvgPacientes;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Panel pnlDatos;
        private Panel plnEncabezado;
        private Label lblTitulo;
        private Label lblIcono;
        private Label LBLSubtitulo;
    }
}