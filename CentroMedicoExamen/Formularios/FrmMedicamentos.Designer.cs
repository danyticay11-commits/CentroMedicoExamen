namespace CentroMedicoExamen.Formularios
{
    partial class FrmMedicamentos
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
            lblNombreMedicamento = new Label();
            lblPresentacion = new Label();
            txtNombreMedicamento = new TextBox();
            txtPresentacion = new TextBox();
            lblStock = new Label();
            txtStock = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvMedicamentos = new DataGridView();
            pnlTitulo = new Panel();
            lblIcono = new Label();
            label1 = new Label();
            lblMedicamentos = new Label();
            pnlDatos = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            pnlTitulo.SuspendLayout();
            pnlDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreMedicamento
            // 
            lblNombreMedicamento.AutoSize = true;
            lblNombreMedicamento.BackColor = Color.White;
            lblNombreMedicamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreMedicamento.ForeColor = Color.MidnightBlue;
            lblNombreMedicamento.Location = new Point(12, 18);
            lblNombreMedicamento.Name = "lblNombreMedicamento";
            lblNombreMedicamento.Size = new Size(196, 20);
            lblNombreMedicamento.TabIndex = 0;
            lblNombreMedicamento.Text = "Nombre del Medicamento:";
            // 
            // lblPresentacion
            // 
            lblPresentacion.AutoSize = true;
            lblPresentacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPresentacion.ForeColor = Color.MidnightBlue;
            lblPresentacion.Location = new Point(513, 18);
            lblPresentacion.Name = "lblPresentacion";
            lblPresentacion.Size = new Size(103, 20);
            lblPresentacion.TabIndex = 1;
            lblPresentacion.Text = "Presentacion:";
            lblPresentacion.Click += lblPresentacion_Click;
            // 
            // txtNombreMedicamento
            // 
            txtNombreMedicamento.Location = new Point(214, 15);
            txtNombreMedicamento.Multiline = true;
            txtNombreMedicamento.Name = "txtNombreMedicamento";
            txtNombreMedicamento.Size = new Size(278, 34);
            txtNombreMedicamento.TabIndex = 2;
            // 
            // txtPresentacion
            // 
            txtPresentacion.Location = new Point(622, 15);
            txtPresentacion.Multiline = true;
            txtPresentacion.Name = "txtPresentacion";
            txtPresentacion.Size = new Size(288, 34);
            txtPresentacion.TabIndex = 3;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.MidnightBlue;
            lblStock.Location = new Point(935, 18);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(52, 20);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(1009, 18);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(131, 34);
            txtStock.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(309, 80);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
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
            btnModificar.Location = new Point(442, 80);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 7;
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
            btnEliminar.Location = new Point(565, 80);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 8;
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
            btnLimpiar.Location = new Point(693, 80);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.CommandParameterChanged += btnLimpiar_CommandParameterChanged;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.GridColor = SystemColors.ScrollBar;
            dgvMedicamentos.Location = new Point(0, 256);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.RowHeadersWidth = 51;
            dgvMedicamentos.Size = new Size(1153, 357);
            dgvMedicamentos.TabIndex = 10;
            dgvMedicamentos.CellClick += dgvMedicamentos_CellClick;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.MidnightBlue;
            pnlTitulo.Controls.Add(lblIcono);
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Controls.Add(lblMedicamentos);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1153, 125);
            pnlTitulo.TabIndex = 11;
            // 
            // lblIcono
            // 
            lblIcono.AutoSize = true;
            lblIcono.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIcono.ForeColor = Color.White;
            lblIcono.Location = new Point(237, 0);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(69, 62);
            lblIcono.TabIndex = 18;
            lblIcono.Text = "✚";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(352, 62);
            label1.Name = "label1";
            label1.Size = new Size(421, 23);
            label1.TabIndex = 1;
            label1.Text = "Programación y Gestión del Stock de Medicamentos";
            // 
            // lblMedicamentos
            // 
            lblMedicamentos.AutoSize = true;
            lblMedicamentos.BackColor = Color.MidnightBlue;
            lblMedicamentos.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedicamentos.ForeColor = Color.White;
            lblMedicamentos.Location = new Point(298, 0);
            lblMedicamentos.Name = "lblMedicamentos";
            lblMedicamentos.Size = new Size(598, 62);
            lblMedicamentos.TabIndex = 0;
            lblMedicamentos.Text = "Gestión de Medicamentos";
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.White;
            pnlDatos.Controls.Add(lblNombreMedicamento);
            pnlDatos.Controls.Add(txtNombreMedicamento);
            pnlDatos.Controls.Add(lblPresentacion);
            pnlDatos.Controls.Add(btnLimpiar);
            pnlDatos.Controls.Add(txtPresentacion);
            pnlDatos.Controls.Add(btnModificar);
            pnlDatos.Controls.Add(btnEliminar);
            pnlDatos.Controls.Add(lblStock);
            pnlDatos.Controls.Add(txtStock);
            pnlDatos.Controls.Add(btnGuardar);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 125);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1153, 125);
            pnlDatos.TabIndex = 19;
            // 
            // FrmMedicamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1153, 677);
            Controls.Add(pnlDatos);
            Controls.Add(pnlTitulo);
            Controls.Add(dgvMedicamentos);
            Name = "FrmMedicamentos";
            Text = "Gestion de Medicamentos ";
            Load += FrmMedicamentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombreMedicamento;
        private Label lblPresentacion;
        private TextBox txtNombreMedicamento;
        private TextBox txtPresentacion;
        private Label lblStock;
        private TextBox txtStock;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvMedicamentos;
        private Panel pnlTitulo;
        private Label lblMedicamentos;
        private Label label1;
        private Panel pnlDatos;
        private Label lblIcono;
    }
}