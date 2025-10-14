
namespace MedicalHistory
{
    partial class citas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(citas));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbhis = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtfecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dthora = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvcitas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clinicaDataSet = new MedicalHistory.clinicaDataSet();
            this.citasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citasTableAdapter = new MedicalHistory.clinicaDataSetTableAdapters.citasTableAdapter();
            this.bteditar = new Guna.UI2.WinForms.Guna2Button();
            this.btdelete = new Guna.UI2.WinForms.Guna2Button();
            this.btagregar = new Guna.UI2.WinForms.Guna2Button();
            this.tbbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.idpacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idhistorialmedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbmedico = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbpacientes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.tbbuscar);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2GradientPanel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(758, 55);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Citas";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Azure;
            this.splitContainer1.Panel1.Controls.Add(this.bteditar);
            this.splitContainer1.Panel1.Controls.Add(this.btdelete);
            this.splitContainer1.Panel1.Controls.Add(this.btagregar);
            this.splitContainer1.Panel1.Controls.Add(this.dthora);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.dtfecha);
            this.splitContainer1.Panel1.Controls.Add(this.tbhis);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.cbmedico);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cbpacientes);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.splitContainer1.Panel2.Controls.Add(this.dgvcitas);
            this.splitContainer1.Size = new System.Drawing.Size(758, 495);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pacientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Médico";
            // 
            // tbhis
            // 
            this.tbhis.BorderColor = System.Drawing.Color.DarkCyan;
            this.tbhis.BorderRadius = 5;
            this.tbhis.BorderThickness = 2;
            this.tbhis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbhis.DefaultText = "";
            this.tbhis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbhis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbhis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbhis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbhis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbhis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbhis.Location = new System.Drawing.Point(17, 167);
            this.tbhis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbhis.Name = "tbhis";
            this.tbhis.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbhis.PlaceholderText = "Historial Médico";
            this.tbhis.SelectedText = "";
            this.tbhis.Size = new System.Drawing.Size(218, 41);
            this.tbhis.TabIndex = 5;
            this.tbhis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtfecha
            // 
            this.dtfecha.Checked = true;
            this.dtfecha.FillColor = System.Drawing.Color.LightSeaGreen;
            this.dtfecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtfecha.Location = new System.Drawing.Point(17, 252);
            this.dtfecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtfecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(218, 38);
            this.dtfecha.TabIndex = 6;
            this.dtfecha.Value = new System.DateTime(2025, 10, 13, 15, 12, 49, 598);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hora:";
            // 
            // dthora
            // 
            this.dthora.Checked = true;
            this.dthora.FillColor = System.Drawing.Color.LightSeaGreen;
            this.dthora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dthora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dthora.Location = new System.Drawing.Point(17, 332);
            this.dthora.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dthora.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dthora.Name = "dthora";
            this.dthora.Size = new System.Drawing.Size(218, 38);
            this.dthora.TabIndex = 9;
            this.dthora.Value = new System.DateTime(2025, 10, 13, 15, 12, 49, 598);
            // 
            // dgvcitas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvcitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcitas.AutoGenerateColumns = false;
            this.dgvcitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcitas.ColumnHeadersHeight = 44;
            this.dgvcitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvcitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpacienteDataGridViewTextBoxColumn,
            this.fechacitaDataGridViewTextBoxColumn,
            this.diaDataGridViewTextBoxColumn,
            this.idhistorialmedicoDataGridViewTextBoxColumn,
            this.idempleadoDataGridViewTextBoxColumn});
            this.dgvcitas.DataSource = this.citasBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcitas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcitas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvcitas.Location = new System.Drawing.Point(12, 108);
            this.dgvcitas.Name = "dgvcitas";
            this.dgvcitas.RowHeadersVisible = false;
            this.dgvcitas.RowHeadersWidth = 50;
            this.dgvcitas.RowTemplate.DividerHeight = 2;
            this.dgvcitas.Size = new System.Drawing.Size(478, 306);
            this.dgvcitas.TabIndex = 0;
            this.dgvcitas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvcitas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvcitas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvcitas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvcitas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvcitas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvcitas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvcitas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dgvcitas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvcitas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcitas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvcitas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvcitas.ThemeStyle.HeaderStyle.Height = 44;
            this.dgvcitas.ThemeStyle.ReadOnly = false;
            this.dgvcitas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvcitas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvcitas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcitas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvcitas.ThemeStyle.RowsStyle.Height = 22;
            this.dgvcitas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvcitas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvcitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcitas_CellClick);
            this.dgvcitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcitas_CellContentClick);
            // 
            // clinicaDataSet
            // 
            this.clinicaDataSet.DataSetName = "clinicaDataSet";
            this.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasBindingSource
            // 
            this.citasBindingSource.DataMember = "citas";
            this.citasBindingSource.DataSource = this.clinicaDataSet;
            // 
            // citasTableAdapter
            // 
            this.citasTableAdapter.ClearBeforeFill = true;
            // 
            // bteditar
            // 
            this.bteditar.BorderRadius = 5;
            this.bteditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bteditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bteditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bteditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bteditar.FillColor = System.Drawing.Color.CadetBlue;
            this.bteditar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bteditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditar.ForeColor = System.Drawing.Color.Black;
            this.bteditar.Image = ((System.Drawing.Image)(resources.GetObject("bteditar.Image")));
            this.bteditar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bteditar.Location = new System.Drawing.Point(65, 452);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(115, 26);
            this.bteditar.TabIndex = 12;
            this.bteditar.Text = "Modificar";
            // 
            // btdelete
            // 
            this.btdelete.BorderRadius = 5;
            this.btdelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btdelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btdelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btdelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btdelete.FillColor = System.Drawing.Color.CadetBlue;
            this.btdelete.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btdelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.ForeColor = System.Drawing.Color.Black;
            this.btdelete.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.Image")));
            this.btdelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btdelete.Location = new System.Drawing.Point(65, 420);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(115, 26);
            this.btdelete.TabIndex = 11;
            this.btdelete.Text = "Eliminar";
            // 
            // btagregar
            // 
            this.btagregar.BorderRadius = 5;
            this.btagregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btagregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btagregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btagregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btagregar.FillColor = System.Drawing.Color.CadetBlue;
            this.btagregar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btagregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagregar.ForeColor = System.Drawing.Color.Black;
            this.btagregar.Image = ((System.Drawing.Image)(resources.GetObject("btagregar.Image")));
            this.btagregar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btagregar.Location = new System.Drawing.Point(65, 388);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(115, 26);
            this.btagregar.TabIndex = 10;
            this.btagregar.Text = "Agregar";
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
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
            this.tbbuscar.ForeColor = System.Drawing.Color.Black;
            this.tbbuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbbuscar.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbbuscar.IconLeft")));
            this.tbbuscar.Location = new System.Drawing.Point(548, 15);
            this.tbbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbbuscar.PlaceholderText = "Buscar";
            this.tbbuscar.SelectedText = "";
            this.tbbuscar.Size = new System.Drawing.Size(175, 28);
            this.tbbuscar.TabIndex = 17;
            this.tbbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idpacienteDataGridViewTextBoxColumn
            // 
            this.idpacienteDataGridViewTextBoxColumn.DataPropertyName = "id_paciente";
            this.idpacienteDataGridViewTextBoxColumn.HeaderText = "ID Paciente";
            this.idpacienteDataGridViewTextBoxColumn.Name = "idpacienteDataGridViewTextBoxColumn";
            // 
            // fechacitaDataGridViewTextBoxColumn
            // 
            this.fechacitaDataGridViewTextBoxColumn.DataPropertyName = "fecha_cita";
            this.fechacitaDataGridViewTextBoxColumn.HeaderText = "Fecha de Cita";
            this.fechacitaDataGridViewTextBoxColumn.Name = "fechacitaDataGridViewTextBoxColumn";
            // 
            // diaDataGridViewTextBoxColumn
            // 
            this.diaDataGridViewTextBoxColumn.DataPropertyName = "dia";
            this.diaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            // 
            // idhistorialmedicoDataGridViewTextBoxColumn
            // 
            this.idhistorialmedicoDataGridViewTextBoxColumn.DataPropertyName = "id_historial_medico";
            this.idhistorialmedicoDataGridViewTextBoxColumn.HeaderText = "ID Historial Medico";
            this.idhistorialmedicoDataGridViewTextBoxColumn.Name = "idhistorialmedicoDataGridViewTextBoxColumn";
            // 
            // idempleadoDataGridViewTextBoxColumn
            // 
            this.idempleadoDataGridViewTextBoxColumn.DataPropertyName = "id_empleado";
            this.idempleadoDataGridViewTextBoxColumn.HeaderText = "ID Empleado";
            this.idempleadoDataGridViewTextBoxColumn.Name = "idempleadoDataGridViewTextBoxColumn";
            // 
            // cbmedico
            // 
            this.cbmedico.BackColor = System.Drawing.Color.Transparent;
            this.cbmedico.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmedico.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmedico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmedico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbmedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbmedico.ItemHeight = 30;
            this.cbmedico.Location = new System.Drawing.Point(17, 118);
            this.cbmedico.Name = "cbmedico";
            this.cbmedico.Size = new System.Drawing.Size(218, 36);
            this.cbmedico.TabIndex = 2;
            this.cbmedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbpacientes
            // 
            this.cbpacientes.BackColor = System.Drawing.Color.Transparent;
            this.cbpacientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbpacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpacientes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbpacientes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbpacientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbpacientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbpacientes.ItemHeight = 30;
            this.cbpacientes.Location = new System.Drawing.Point(17, 39);
            this.cbpacientes.Name = "cbpacientes";
            this.cbpacientes.Size = new System.Drawing.Size(218, 36);
            this.cbpacientes.TabIndex = 0;
            this.cbpacientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 550);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "citas";
            this.Text = "citas";
            this.Load += new System.EventHandler(this.citas_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox tbbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbhis;
        private Guna.UI2.WinForms.Guna2DateTimePicker dthora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtfecha;
        private Guna.UI2.WinForms.Guna2Button bteditar;
        private Guna.UI2.WinForms.Guna2Button btdelete;
        private Guna.UI2.WinForms.Guna2Button btagregar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvcitas;
        private clinicaDataSet clinicaDataSet;
        private System.Windows.Forms.BindingSource citasBindingSource;
        private clinicaDataSetTableAdapters.citasTableAdapter citasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhistorialmedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempleadoDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2ComboBox cbmedico;
        private Guna.UI2.WinForms.Guna2ComboBox cbpacientes;
    }
}