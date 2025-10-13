
namespace MedicalHistory
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbtuser = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbtpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.accederbtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.salirbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 732);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 732);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(868, 160);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tbtuser
            // 
            this.tbtuser.BorderRadius = 8;
            this.tbtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtuser.DefaultText = "";
            this.tbtuser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbtuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbtuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtuser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtuser.FillColor = System.Drawing.Color.MintCream;
            this.tbtuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtuser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtuser.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbtuser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtuser.Location = new System.Drawing.Point(784, 303);
            this.tbtuser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbtuser.Name = "tbtuser";
            this.tbtuser.PlaceholderForeColor = System.Drawing.Color.MidnightBlue;
            this.tbtuser.PlaceholderText = "Usuario";
            this.tbtuser.SelectedText = "";
            this.tbtuser.Size = new System.Drawing.Size(302, 65);
            this.tbtuser.TabIndex = 2;
            this.tbtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbtpass
            // 
            this.tbtpass.BorderRadius = 8;
            this.tbtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtpass.DefaultText = "";
            this.tbtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtpass.FillColor = System.Drawing.Color.MintCream;
            this.tbtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtpass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtpass.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtpass.Location = new System.Drawing.Point(784, 420);
            this.tbtpass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbtpass.Name = "tbtpass";
            this.tbtpass.PasswordChar = '*';
            this.tbtpass.PlaceholderForeColor = System.Drawing.Color.MidnightBlue;
            this.tbtpass.PlaceholderText = "Contraseña";
            this.tbtpass.SelectedText = "";
            this.tbtpass.Size = new System.Drawing.Size(302, 65);
            this.tbtpass.TabIndex = 3;
            this.tbtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // accederbtn
            // 
            this.accederbtn.BorderColor = System.Drawing.Color.Navy;
            this.accederbtn.BorderThickness = 2;
            this.accederbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.accederbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.accederbtn.DisabledState.FillColor = System.Drawing.Color.Navy;
            this.accederbtn.DisabledState.ForeColor = System.Drawing.Color.White;
            this.accederbtn.FillColor = System.Drawing.Color.White;
            this.accederbtn.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accederbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.accederbtn.Location = new System.Drawing.Point(868, 538);
            this.accederbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accederbtn.Name = "accederbtn";
            this.accederbtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.accederbtn.Size = new System.Drawing.Size(142, 82);
            this.accederbtn.TabIndex = 4;
            this.accederbtn.Text = "Acceder";
            this.accederbtn.Click += new System.EventHandler(this.accederbtn_Click);
            // 
            // salirbtn
            // 
            this.salirbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.salirbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.salirbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salirbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.salirbtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirbtn.ForeColor = System.Drawing.Color.White;
            this.salirbtn.Location = new System.Drawing.Point(1155, 0);
            this.salirbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salirbtn.Name = "salirbtn";
            this.salirbtn.Size = new System.Drawing.Size(48, 51);
            this.salirbtn.TabIndex = 5;
            this.salirbtn.Text = "x";
            this.salirbtn.Click += new System.EventHandler(this.salirbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1198, 731);
            this.Controls.Add(this.salirbtn);
            this.Controls.Add(this.accederbtn);
            this.Controls.Add(this.tbtpass);
            this.Controls.Add(this.tbtuser);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox tbtuser;
        private Guna.UI2.WinForms.Guna2TextBox tbtpass;
        private Guna.UI2.WinForms.Guna2CircleButton accederbtn;
        private Guna.UI2.WinForms.Guna2Button salirbtn;
    }
}

