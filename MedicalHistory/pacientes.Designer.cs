
namespace MedicalHistory
{
    partial class pacientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pacientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.tbbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvpacientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clinicaDataSet = new MedicalHistory.clinicaDataSet();
            this.clinicaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new MedicalHistory.clinicaDataSetTableAdapters.pacientesTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.idpacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idhistorialmedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpacientetb = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbnombrep = new Guna.UI2.WinForms.Guna2TextBox();
            this.apellidotb = new Guna.UI2.WinForms.Guna2TextBox();
            this.cedulatb = new Guna.UI2.WinForms.Guna2TextBox();
            this.edadtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.direcciontb = new Guna.UI2.WinForms.Guna2TextBox();
            this.telefonotb = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbcorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbhistorial = new Guna.UI2.WinForms.Guna2TextBox();
            this.btagregar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btimprimir = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Pacientes";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.tbbuscar);
            this.guna2GradientPanel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2GradientPanel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(774, 55);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(714, 7);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(48, 48);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 16;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // tbbuscar
            // 
            this.tbbuscar.BackColor = System.Drawing.Color.Transparent;
            this.tbbuscar.BorderRadius = 8;
            this.tbbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbbuscar.DefaultText = "";
            this.tbbuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbbuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbbuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbbuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbbuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbbuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbbuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbuscar.ForeColor = System.Drawing.Color.White;
            this.tbbuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbbuscar.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbbuscar.IconLeft")));
            this.tbbuscar.Location = new System.Drawing.Point(497, 18);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbbuscar.PlaceholderText = "Buscar";
            this.tbbuscar.SelectedText = "";
            this.tbbuscar.Size = new System.Drawing.Size(175, 28);
            this.tbbuscar.TabIndex = 17;
            this.tbbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvpacientes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvpacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvpacientes.AutoGenerateColumns = false;
            this.dgvpacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvpacientes.ColumnHeadersHeight = 39;
            this.dgvpacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvpacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.idpacienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.idhistorialmedicoDataGridViewTextBoxColumn});
            this.dgvpacientes.DataSource = this.pacientesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpacientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvpacientes.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvpacientes.Location = new System.Drawing.Point(29, 77);
            this.dgvpacientes.Name = "dgvpacientes";
            this.dgvpacientes.RowHeadersVisible = false;
            this.dgvpacientes.RowTemplate.DividerHeight = 3;
            this.dgvpacientes.RowTemplate.Height = 35;
            this.dgvpacientes.Size = new System.Drawing.Size(712, 349);
            this.dgvpacientes.TabIndex = 2;
            this.dgvpacientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvpacientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvpacientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvpacientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvpacientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvpacientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvpacientes.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvpacientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.CadetBlue;
            this.dgvpacientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvpacientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvpacientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvpacientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvpacientes.ThemeStyle.HeaderStyle.Height = 39;
            this.dgvpacientes.ThemeStyle.ReadOnly = false;
            this.dgvpacientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvpacientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvpacientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvpacientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvpacientes.ThemeStyle.RowsStyle.Height = 35;
            this.dgvpacientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvpacientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clinicaDataSet
            // 
            this.clinicaDataSet.DataSetName = "clinicaDataSet";
            this.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicaDataSetBindingSource
            // 
            this.clinicaDataSetBindingSource.DataSource = this.clinicaDataSet;
            this.clinicaDataSetBindingSource.Position = 0;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "pacientes";
            this.pacientesBindingSource.DataSource = this.clinicaDataSetBindingSource;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "*";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.Width = 20;
            // 
            // idpacienteDataGridViewTextBoxColumn
            // 
            this.idpacienteDataGridViewTextBoxColumn.DataPropertyName = "id_paciente";
            this.idpacienteDataGridViewTextBoxColumn.HeaderText = "ID Paciente";
            this.idpacienteDataGridViewTextBoxColumn.Name = "idpacienteDataGridViewTextBoxColumn";
            this.idpacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpacienteDataGridViewTextBoxColumn.Width = 91;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 81;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.Width = 80;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cédula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.Width = 72;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.Width = 61;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Width = 86;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 82;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.Width = 72;
            // 
            // idhistorialmedicoDataGridViewTextBoxColumn
            // 
            this.idhistorialmedicoDataGridViewTextBoxColumn.DataPropertyName = "id_historial_medico";
            this.idhistorialmedicoDataGridViewTextBoxColumn.HeaderText = "Historial Médico";
            this.idhistorialmedicoDataGridViewTextBoxColumn.Name = "idhistorialmedicoDataGridViewTextBoxColumn";
            this.idhistorialmedicoDataGridViewTextBoxColumn.Width = 118;
            // 
            // idpacientetb
            // 
            this.idpacientetb.BorderColor = System.Drawing.Color.DarkCyan;
            this.idpacientetb.BorderRadius = 5;
            this.idpacientetb.BorderThickness = 2;
            this.idpacientetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idpacientetb.DefaultText = "";
            this.idpacientetb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idpacientetb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idpacientetb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idpacientetb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idpacientetb.FillColor = System.Drawing.Color.AliceBlue;
            this.idpacientetb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idpacientetb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpacientetb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idpacientetb.Location = new System.Drawing.Point(31, 449);
            this.idpacientetb.Name = "idpacientetb";
            this.idpacientetb.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.idpacientetb.PlaceholderText = "ID Paciente";
            this.idpacientetb.SelectedText = "";
            this.idpacientetb.Size = new System.Drawing.Size(113, 31);
            this.idpacientetb.TabIndex = 3;
            this.idpacientetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbnombrep
            // 
            this.tbnombrep.BorderColor = System.Drawing.Color.DarkCyan;
            this.tbnombrep.BorderRadius = 5;
            this.tbnombrep.BorderThickness = 2;
            this.tbnombrep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbnombrep.DefaultText = "";
            this.tbnombrep.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbnombrep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbnombrep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbnombrep.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbnombrep.FillColor = System.Drawing.Color.AliceBlue;
            this.tbnombrep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbnombrep.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnombrep.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbnombrep.Location = new System.Drawing.Point(31, 495);
            this.tbnombrep.Name = "tbnombrep";
            this.tbnombrep.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbnombrep.PlaceholderText = "Nombre";
            this.tbnombrep.SelectedText = "";
            this.tbnombrep.Size = new System.Drawing.Size(113, 31);
            this.tbnombrep.TabIndex = 4;
            this.tbnombrep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // apellidotb
            // 
            this.apellidotb.BorderColor = System.Drawing.Color.DarkCyan;
            this.apellidotb.BorderRadius = 5;
            this.apellidotb.BorderThickness = 2;
            this.apellidotb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.apellidotb.DefaultText = "";
            this.apellidotb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.apellidotb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.apellidotb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.apellidotb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.apellidotb.FillColor = System.Drawing.Color.AliceBlue;
            this.apellidotb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.apellidotb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidotb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.apellidotb.Location = new System.Drawing.Point(31, 539);
            this.apellidotb.Name = "apellidotb";
            this.apellidotb.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.apellidotb.PlaceholderText = "Apellido";
            this.apellidotb.SelectedText = "";
            this.apellidotb.Size = new System.Drawing.Size(113, 31);
            this.apellidotb.TabIndex = 5;
            this.apellidotb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cedulatb
            // 
            this.cedulatb.BorderColor = System.Drawing.Color.DarkCyan;
            this.cedulatb.BorderRadius = 5;
            this.cedulatb.BorderThickness = 2;
            this.cedulatb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cedulatb.DefaultText = "";
            this.cedulatb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cedulatb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cedulatb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cedulatb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cedulatb.FillColor = System.Drawing.Color.AliceBlue;
            this.cedulatb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cedulatb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulatb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cedulatb.Location = new System.Drawing.Point(180, 449);
            this.cedulatb.Name = "cedulatb";
            this.cedulatb.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.cedulatb.PlaceholderText = "Cédula";
            this.cedulatb.SelectedText = "";
            this.cedulatb.Size = new System.Drawing.Size(113, 31);
            this.cedulatb.TabIndex = 6;
            this.cedulatb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edadtb
            // 
            this.edadtb.BorderColor = System.Drawing.Color.DarkCyan;
            this.edadtb.BorderRadius = 5;
            this.edadtb.BorderThickness = 2;
            this.edadtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edadtb.DefaultText = "";
            this.edadtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.edadtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.edadtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edadtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.edadtb.FillColor = System.Drawing.Color.AliceBlue;
            this.edadtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edadtb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.edadtb.Location = new System.Drawing.Point(180, 495);
            this.edadtb.Name = "edadtb";
            this.edadtb.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.edadtb.PlaceholderText = "Edad";
            this.edadtb.SelectedText = "";
            this.edadtb.Size = new System.Drawing.Size(113, 31);
            this.edadtb.TabIndex = 7;
            this.edadtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // direcciontb
            // 
            this.direcciontb.BorderColor = System.Drawing.Color.DarkCyan;
            this.direcciontb.BorderRadius = 5;
            this.direcciontb.BorderThickness = 2;
            this.direcciontb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.direcciontb.DefaultText = "";
            this.direcciontb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.direcciontb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.direcciontb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.direcciontb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.direcciontb.FillColor = System.Drawing.Color.AliceBlue;
            this.direcciontb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.direcciontb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direcciontb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.direcciontb.Location = new System.Drawing.Point(180, 539);
            this.direcciontb.Name = "direcciontb";
            this.direcciontb.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.direcciontb.PlaceholderText = "Dirección";
            this.direcciontb.SelectedText = "";
            this.direcciontb.Size = new System.Drawing.Size(113, 31);
            this.direcciontb.TabIndex = 8;
            this.direcciontb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // telefonotb
            // 
            this.telefonotb.BorderColor = System.Drawing.Color.DarkCyan;
            this.telefonotb.BorderRadius = 5;
            this.telefonotb.BorderThickness = 2;
            this.telefonotb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telefonotb.DefaultText = "";
            this.telefonotb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.telefonotb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.telefonotb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.telefonotb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.telefonotb.FillColor = System.Drawing.Color.AliceBlue;
            this.telefonotb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.telefonotb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonotb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.telefonotb.Location = new System.Drawing.Point(329, 449);
            this.telefonotb.Name = "telefonotb";
            this.telefonotb.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.telefonotb.PlaceholderText = "Teléfono";
            this.telefonotb.SelectedText = "";
            this.telefonotb.Size = new System.Drawing.Size(113, 31);
            this.telefonotb.TabIndex = 9;
            this.telefonotb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbcorreo
            // 
            this.tbcorreo.BorderColor = System.Drawing.Color.DarkCyan;
            this.tbcorreo.BorderRadius = 5;
            this.tbcorreo.BorderThickness = 2;
            this.tbcorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbcorreo.DefaultText = "";
            this.tbcorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbcorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbcorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcorreo.FillColor = System.Drawing.Color.AliceBlue;
            this.tbcorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcorreo.Location = new System.Drawing.Point(329, 539);
            this.tbcorreo.Name = "tbcorreo";
            this.tbcorreo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbcorreo.PlaceholderText = "Correo";
            this.tbcorreo.SelectedText = "";
            this.tbcorreo.Size = new System.Drawing.Size(172, 31);
            this.tbcorreo.TabIndex = 10;
            this.tbcorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbhistorial
            // 
            this.tbhistorial.BorderColor = System.Drawing.Color.DarkCyan;
            this.tbhistorial.BorderRadius = 5;
            this.tbhistorial.BorderThickness = 2;
            this.tbhistorial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbhistorial.DefaultText = "";
            this.tbhistorial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbhistorial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbhistorial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbhistorial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbhistorial.FillColor = System.Drawing.Color.AliceBlue;
            this.tbhistorial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbhistorial.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhistorial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbhistorial.Location = new System.Drawing.Point(329, 495);
            this.tbhistorial.Name = "tbhistorial";
            this.tbhistorial.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbhistorial.PlaceholderText = "Historial Médico";
            this.tbhistorial.SelectedText = "";
            this.tbhistorial.Size = new System.Drawing.Size(140, 31);
            this.tbhistorial.TabIndex = 11;
            this.tbhistorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btagregar
            // 
            this.btagregar.BorderColor = System.Drawing.Color.LightGray;
            this.btagregar.BorderRadius = 8;
            this.btagregar.BorderThickness = 3;
            this.btagregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btagregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btagregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btagregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btagregar.FillColor = System.Drawing.Color.DarkCyan;
            this.btagregar.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagregar.ForeColor = System.Drawing.Color.Black;
            this.btagregar.Image = ((System.Drawing.Image)(resources.GetObject("btagregar.Image")));
            this.btagregar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btagregar.ImageSize = new System.Drawing.Size(18, 18);
            this.btagregar.Location = new System.Drawing.Point(623, 449);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(119, 31);
            this.btagregar.TabIndex = 12;
            this.btagregar.Text = "Agregar";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DarkCyan;
            this.guna2Button1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(18, 18);
            this.guna2Button1.Location = new System.Drawing.Point(623, 495);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guna2Button1.Size = new System.Drawing.Size(119, 31);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Text = "Modificar";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.BorderThickness = 3;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.DarkCyan;
            this.guna2Button2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageSize = new System.Drawing.Size(18, 18);
            this.guna2Button2.Location = new System.Drawing.Point(623, 539);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(119, 31);
            this.guna2Button2.TabIndex = 14;
            this.guna2Button2.Text = "Eliminar";
            // 
            // btimprimir
            // 
            this.btimprimir.BorderColor = System.Drawing.Color.DimGray;
            this.btimprimir.BorderRadius = 7;
            this.btimprimir.BorderThickness = 1;
            this.btimprimir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btimprimir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btimprimir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btimprimir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btimprimir.FillColor = System.Drawing.Color.Gainsboro;
            this.btimprimir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btimprimir.ForeColor = System.Drawing.Color.White;
            this.btimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btimprimir.Image")));
            this.btimprimir.ImageSize = new System.Drawing.Size(25, 25);
            this.btimprimir.Location = new System.Drawing.Point(528, 482);
            this.btimprimir.Name = "btimprimir";
            this.btimprimir.Size = new System.Drawing.Size(52, 44);
            this.btimprimir.TabIndex = 18;
            // 
            // pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 589);
            this.Controls.Add(this.btimprimir);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.tbhistorial);
            this.Controls.Add(this.tbcorreo);
            this.Controls.Add(this.telefonotb);
            this.Controls.Add(this.direcciontb);
            this.Controls.Add(this.edadtb);
            this.Controls.Add(this.cedulatb);
            this.Controls.Add(this.apellidotb);
            this.Controls.Add(this.tbnombrep);
            this.Controls.Add(this.idpacientetb);
            this.Controls.Add(this.dgvpacientes);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pacientes";
            this.Text = "pacientes";
            this.Load += new System.EventHandler(this.pacientes_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbbuscar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvpacientes;
        private System.Windows.Forms.BindingSource clinicaDataSetBindingSource;
        private clinicaDataSet clinicaDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private clinicaDataSetTableAdapters.pacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhistorialmedicoDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2TextBox idpacientetb;
        private Guna.UI2.WinForms.Guna2TextBox tbnombrep;
        private Guna.UI2.WinForms.Guna2TextBox apellidotb;
        private Guna.UI2.WinForms.Guna2TextBox cedulatb;
        private Guna.UI2.WinForms.Guna2TextBox edadtb;
        private Guna.UI2.WinForms.Guna2TextBox direcciontb;
        private Guna.UI2.WinForms.Guna2TextBox telefonotb;
        private Guna.UI2.WinForms.Guna2TextBox tbcorreo;
        private Guna.UI2.WinForms.Guna2TextBox tbhistorial;
        private Guna.UI2.WinForms.Guna2Button btagregar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btimprimir;
    }
}