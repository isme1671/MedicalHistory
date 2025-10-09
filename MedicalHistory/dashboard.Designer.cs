
namespace MedicalHistory
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.pimagenes = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.heartbt = new Guna.UI2.WinForms.Guna2Button();
            this.pulmbt = new Guna.UI2.WinForms.Guna2Button();
            this.cerebt = new Guna.UI2.WinForms.Guna2Button();
            this.cuerpbt = new Guna.UI2.WinForms.Guna2Button();
            this.piesbt = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.picbody = new System.Windows.Forms.PictureBox();
            this.pimagenes.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbody)).BeginInit();
            this.SuspendLayout();
            // 
            // pimagenes
            // 
            this.pimagenes.Controls.Add(this.picbody);
            this.pimagenes.Location = new System.Drawing.Point(72, 149);
            this.pimagenes.Name = "pimagenes";
            this.pimagenes.Size = new System.Drawing.Size(298, 277);
            this.pimagenes.TabIndex = 1;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 15;
            this.guna2CustomGradientPanel1.Controls.Add(this.piesbt);
            this.guna2CustomGradientPanel1.Controls.Add(this.cuerpbt);
            this.guna2CustomGradientPanel1.Controls.Add(this.cerebt);
            this.guna2CustomGradientPanel1.Controls.Add(this.heartbt);
            this.guna2CustomGradientPanel1.Controls.Add(this.pulmbt);
            this.guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.LightBlue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.LightBlue;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.LightBlue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(12, 106);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(429, 32);
            this.guna2CustomGradientPanel1.TabIndex = 4;
            // 
            // heartbt
            // 
            this.heartbt.BorderRadius = 9;
            this.heartbt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.heartbt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.heartbt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.heartbt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.heartbt.FillColor = System.Drawing.Color.White;
            this.heartbt.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartbt.ForeColor = System.Drawing.Color.Black;
            this.heartbt.Location = new System.Drawing.Point(6, 3);
            this.heartbt.Name = "heartbt";
            this.heartbt.Size = new System.Drawing.Size(71, 26);
            this.heartbt.TabIndex = 5;
            this.heartbt.Text = "Corazón";
            this.heartbt.Click += new System.EventHandler(this.heartbt_Click);
            // 
            // pulmbt
            // 
            this.pulmbt.BorderRadius = 9;
            this.pulmbt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pulmbt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pulmbt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pulmbt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pulmbt.FillColor = System.Drawing.Color.White;
            this.pulmbt.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulmbt.ForeColor = System.Drawing.Color.Black;
            this.pulmbt.Location = new System.Drawing.Point(83, 3);
            this.pulmbt.Name = "pulmbt";
            this.pulmbt.Size = new System.Drawing.Size(80, 26);
            this.pulmbt.TabIndex = 6;
            this.pulmbt.Text = "Pulmones";
            this.pulmbt.Click += new System.EventHandler(this.pulmbt_Click);
            // 
            // cerebt
            // 
            this.cerebt.BorderRadius = 9;
            this.cerebt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cerebt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cerebt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cerebt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cerebt.FillColor = System.Drawing.Color.White;
            this.cerebt.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerebt.ForeColor = System.Drawing.Color.Black;
            this.cerebt.Location = new System.Drawing.Point(169, 3);
            this.cerebt.Name = "cerebt";
            this.cerebt.Size = new System.Drawing.Size(80, 26);
            this.cerebt.TabIndex = 7;
            this.cerebt.Text = "Cerebro";
            this.cerebt.Click += new System.EventHandler(this.cerebt_Click);
            // 
            // cuerpbt
            // 
            this.cuerpbt.BorderRadius = 9;
            this.cuerpbt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cuerpbt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cuerpbt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cuerpbt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cuerpbt.FillColor = System.Drawing.Color.White;
            this.cuerpbt.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuerpbt.ForeColor = System.Drawing.Color.Black;
            this.cuerpbt.Location = new System.Drawing.Point(255, 3);
            this.cuerpbt.Name = "cuerpbt";
            this.cuerpbt.Size = new System.Drawing.Size(80, 26);
            this.cuerpbt.TabIndex = 8;
            this.cuerpbt.Text = "Cuerpo";
            this.cuerpbt.Click += new System.EventHandler(this.cuerpbt_Click);
            // 
            // piesbt
            // 
            this.piesbt.BorderRadius = 9;
            this.piesbt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.piesbt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.piesbt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.piesbt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.piesbt.FillColor = System.Drawing.Color.White;
            this.piesbt.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piesbt.ForeColor = System.Drawing.Color.Black;
            this.piesbt.Location = new System.Drawing.Point(341, 3);
            this.piesbt.Name = "piesbt";
            this.piesbt.Size = new System.Drawing.Size(80, 26);
            this.piesbt.TabIndex = 9;
            this.piesbt.Text = "Pies";
            this.piesbt.Click += new System.EventHandler(this.piesbt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buenos Días";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(398, 404);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cancelaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Citas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(585, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingresados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(676, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Visitas";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.LightCyan;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(491, 102);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(268, 36);
            this.guna2DateTimePicker1.TabIndex = 12;
            this.guna2DateTimePicker1.Value = new System.DateTime(2025, 10, 8, 21, 21, 34, 369);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bienvenido";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.CadetBlue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-1, 77);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(774, 10);
            this.guna2GradientPanel1.TabIndex = 14;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(616, 1);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(79, 72);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 15;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // picbody
            // 
            this.picbody.Location = new System.Drawing.Point(4, 4);
            this.picbody.Name = "picbody";
            this.picbody.Size = new System.Drawing.Size(291, 270);
            this.picbody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbody.TabIndex = 0;
            this.picbody.TabStop = false;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 589);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.pimagenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.pimagenes.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pimagenes;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button piesbt;
        private Guna.UI2.WinForms.Guna2Button cuerpbt;
        private Guna.UI2.WinForms.Guna2Button cerebt;
        private Guna.UI2.WinForms.Guna2Button heartbt;
        private Guna.UI2.WinForms.Guna2Button pulmbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.PictureBox picbody;
    }
}