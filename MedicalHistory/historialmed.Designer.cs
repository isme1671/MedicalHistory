
namespace MedicalHistory
{
    partial class historialmed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historialmed));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tbbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btimprimir = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btagregar = new Guna.UI2.WinForms.Guna2Button();
            this.tbcoment = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbobs = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbtrata = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbmotc = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbfcon = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvpacientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clinicaDataSet = new MedicalHistory.clinicaDataSet();
            this.historialmedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historial_medicoTableAdapter = new MedicalHistory.clinicaDataSetTableAdapters.historial_medicoTableAdapter();
            this.idhistorialmedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaconsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivodeconsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialmedicoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.guna2GradientPanel1.TabIndex = 2;
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
            this.tbbuscar.Location = new System.Drawing.Point(496, 17);
            this.tbbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbbuscar.PlaceholderText = "Buscar";
            this.tbbuscar.SelectedText = "";
            this.tbbuscar.Size = new System.Drawing.Size(175, 28);
            this.tbbuscar.TabIndex = 17;
            this.tbbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(713, 6);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(48, 48);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 16;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial Médico";
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
            this.btimprimir.Location = new System.Drawing.Point(484, 485);
            this.btimprimir.Name = "btimprimir";
            this.btimprimir.Size = new System.Drawing.Size(52, 44);
            this.btimprimir.TabIndex = 31;
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
            this.guna2Button2.Location = new System.Drawing.Point(619, 542);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(119, 31);
            this.guna2Button2.TabIndex = 30;
            this.guna2Button2.Text = "Eliminar";
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
            this.guna2Button1.Location = new System.Drawing.Point(619, 498);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guna2Button1.Size = new System.Drawing.Size(119, 31);
            this.guna2Button1.TabIndex = 29;
            this.guna2Button1.Text = "Modificar";
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
            this.btagregar.Location = new System.Drawing.Point(619, 452);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(119, 31);
            this.btagregar.TabIndex = 28;
            this.btagregar.Text = "Agregar";
            // 
            // tbcoment
            // 
            this.tbcoment.BorderColor = System.Drawing.Color.DarkCyan;
            this.tbcoment.BorderRadius = 5;
            this.tbcoment.BorderThickness = 2;
            this.tbcoment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbcoment.DefaultText = "";
            this.tbcoment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbcoment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbcoment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcoment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcoment.FillColor = System.Drawing.Color.AliceBlue;
            this.tbcoment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcoment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcoment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcoment.Location = new System.Drawing.Point(165, 542);
            this.tbcoment.Name = "tbcoment";
            this.tbcoment.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbcoment.PlaceholderText = "Comentario";
            this.tbcoment.SelectedText = "";
            this.tbcoment.Size = new System.Drawing.Size(113, 31);
            this.tbcoment.TabIndex = 24;
            this.tbcoment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbobs
            // 
            this.tbobs.BorderColor = System.Drawing.Color.DarkCyan;
            this.tbobs.BorderRadius = 5;
            this.tbobs.BorderThickness = 2;
            this.tbobs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbobs.DefaultText = "";
            this.tbobs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbobs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbobs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbobs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbobs.FillColor = System.Drawing.Color.AliceBlue;
            this.tbobs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbobs.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbobs.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbobs.Location = new System.Drawing.Point(315, 542);
            this.tbobs.Name = "tbobs";
            this.tbobs.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbobs.PlaceholderText = "Observación";
            this.tbobs.SelectedText = "";
            this.tbobs.Size = new System.Drawing.Size(113, 31);
            this.tbobs.TabIndex = 23;
            this.tbobs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbtrata
            // 
            this.tbtrata.BorderColor = System.Drawing.Color.DarkCyan;
            this.tbtrata.BorderRadius = 5;
            this.tbtrata.BorderThickness = 2;
            this.tbtrata.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtrata.DefaultText = "";
            this.tbtrata.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbtrata.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbtrata.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtrata.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtrata.FillColor = System.Drawing.Color.AliceBlue;
            this.tbtrata.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtrata.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtrata.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtrata.Location = new System.Drawing.Point(17, 542);
            this.tbtrata.Name = "tbtrata";
            this.tbtrata.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbtrata.PlaceholderText = "Tratamiento";
            this.tbtrata.SelectedText = "";
            this.tbtrata.Size = new System.Drawing.Size(113, 31);
            this.tbtrata.TabIndex = 22;
            this.tbtrata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbmotc
            // 
            this.tbmotc.BorderColor = System.Drawing.Color.DarkCyan;
            this.tbmotc.BorderRadius = 5;
            this.tbmotc.BorderThickness = 2;
            this.tbmotc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbmotc.DefaultText = "";
            this.tbmotc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbmotc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbmotc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbmotc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbmotc.FillColor = System.Drawing.Color.AliceBlue;
            this.tbmotc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbmotc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmotc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbmotc.Location = new System.Drawing.Point(17, 498);
            this.tbmotc.Name = "tbmotc";
            this.tbmotc.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbmotc.PlaceholderText = "Motivo de Consulta";
            this.tbmotc.SelectedText = "";
            this.tbmotc.Size = new System.Drawing.Size(411, 31);
            this.tbmotc.TabIndex = 21;
            this.tbmotc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbfcon
            // 
            this.tbfcon.BorderColor = System.Drawing.Color.DarkCyan;
            this.tbfcon.BorderRadius = 5;
            this.tbfcon.BorderThickness = 2;
            this.tbfcon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbfcon.DefaultText = "";
            this.tbfcon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbfcon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbfcon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbfcon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbfcon.FillColor = System.Drawing.Color.AliceBlue;
            this.tbfcon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbfcon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfcon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbfcon.Location = new System.Drawing.Point(17, 452);
            this.tbfcon.Name = "tbfcon";
            this.tbfcon.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbfcon.PlaceholderText = "Fecha de Consulta";
            this.tbfcon.SelectedText = "";
            this.tbfcon.Size = new System.Drawing.Size(193, 31);
            this.tbfcon.TabIndex = 20;
            this.tbfcon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvpacientes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvpacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvpacientes.AutoGenerateColumns = false;
            this.dgvpacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
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
            this.idhistorialmedicoDataGridViewTextBoxColumn,
            this.fechaconsultaDataGridViewTextBoxColumn,
            this.motivodeconsultaDataGridViewTextBoxColumn,
            this.tratamientoDataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn});
            this.dgvpacientes.DataSource = this.historialmedicoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpacientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvpacientes.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvpacientes.Location = new System.Drawing.Point(29, 82);
            this.dgvpacientes.Name = "dgvpacientes";
            this.dgvpacientes.RowHeadersVisible = false;
            this.dgvpacientes.RowTemplate.DividerHeight = 3;
            this.dgvpacientes.RowTemplate.Height = 35;
            this.dgvpacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvpacientes.Size = new System.Drawing.Size(712, 349);
            this.dgvpacientes.TabIndex = 19;
            this.dgvpacientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvpacientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvpacientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvpacientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvpacientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvpacientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvpacientes.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvpacientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.CadetBlue;
            this.dgvpacientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
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
            // historialmedicoBindingSource
            // 
            this.historialmedicoBindingSource.DataMember = "historial_medico";
            this.historialmedicoBindingSource.DataSource = this.clinicaDataSet;
            // 
            // historial_medicoTableAdapter
            // 
            this.historial_medicoTableAdapter.ClearBeforeFill = true;
            // 
            // idhistorialmedicoDataGridViewTextBoxColumn
            // 
            this.idhistorialmedicoDataGridViewTextBoxColumn.DataPropertyName = "id_historial_medico";
            this.idhistorialmedicoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idhistorialmedicoDataGridViewTextBoxColumn.Name = "idhistorialmedicoDataGridViewTextBoxColumn";
            this.idhistorialmedicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaconsultaDataGridViewTextBoxColumn
            // 
            this.fechaconsultaDataGridViewTextBoxColumn.DataPropertyName = "fecha_consulta";
            this.fechaconsultaDataGridViewTextBoxColumn.HeaderText = "Fecha de Consulta";
            this.fechaconsultaDataGridViewTextBoxColumn.Name = "fechaconsultaDataGridViewTextBoxColumn";
            // 
            // motivodeconsultaDataGridViewTextBoxColumn
            // 
            this.motivodeconsultaDataGridViewTextBoxColumn.DataPropertyName = "motivo_de_consulta";
            this.motivodeconsultaDataGridViewTextBoxColumn.HeaderText = "Motivo de Consulta";
            this.motivodeconsultaDataGridViewTextBoxColumn.Name = "motivodeconsultaDataGridViewTextBoxColumn";
            // 
            // tratamientoDataGridViewTextBoxColumn
            // 
            this.tratamientoDataGridViewTextBoxColumn.DataPropertyName = "tratamiento";
            this.tratamientoDataGridViewTextBoxColumn.HeaderText = "Tratamiento";
            this.tratamientoDataGridViewTextBoxColumn.Name = "tratamientoDataGridViewTextBoxColumn";
            // 
            // observacionDataGridViewTextBoxColumn
            // 
            this.observacionDataGridViewTextBoxColumn.DataPropertyName = "observacion";
            this.observacionDataGridViewTextBoxColumn.HeaderText = "Observación";
            this.observacionDataGridViewTextBoxColumn.Name = "observacionDataGridViewTextBoxColumn";
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            // 
            // historialmed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 589);
            this.Controls.Add(this.btimprimir);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.tbcoment);
            this.Controls.Add(this.tbobs);
            this.Controls.Add(this.tbtrata);
            this.Controls.Add(this.tbmotc);
            this.Controls.Add(this.tbfcon);
            this.Controls.Add(this.dgvpacientes);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "historialmed";
            this.Text = "historialmed";
            this.Load += new System.EventHandler(this.historialmed_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialmedicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox tbbuscar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btimprimir;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btagregar;
        private Guna.UI2.WinForms.Guna2TextBox tbcoment;
        private Guna.UI2.WinForms.Guna2TextBox tbobs;
        private Guna.UI2.WinForms.Guna2TextBox tbtrata;
        private Guna.UI2.WinForms.Guna2TextBox tbmotc;
        private Guna.UI2.WinForms.Guna2TextBox tbfcon;
        private Guna.UI2.WinForms.Guna2DataGridView dgvpacientes;
        private clinicaDataSet clinicaDataSet;
        private System.Windows.Forms.BindingSource historialmedicoBindingSource;
        private clinicaDataSetTableAdapters.historial_medicoTableAdapter historial_medicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhistorialmedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaconsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivodeconsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tratamientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
    }
}