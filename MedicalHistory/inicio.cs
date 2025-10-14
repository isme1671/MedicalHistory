using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalHistory
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }
        private void AbrirForm(Form formulariohijo)
        {
            if (pdad.Controls.Count > 0)
                pdad.Controls.RemoveAt(0);
            formulariohijo.TopLevel = false;
            formulariohijo.FormBorderStyle = FormBorderStyle.None;
            formulariohijo.Dock = DockStyle.Fill;
            pdad.Controls.Add(formulariohijo);
            pdad.Tag = formulariohijo;
            formulariohijo.Show();

        }
        public void abrirfrms (Form formhijo)
        {
            if (this.pdad.Controls.Count > 0)
                this.pdad.Controls.RemoveAt(0);
            formhijo.TopLevel = false;
            formhijo.Dock = DockStyle.Fill;
            this.pdad.Controls.Add(formhijo);
            formhijo.Show();
        }
        private void inicio_Load(object sender, EventArgs e)
        {
            AbrirForm(new dashboard());
        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pacienbt_Click(object sender, EventArgs e)
        {
            AbrirForm(new pacientes());
        }

        private void Dashboardbt_Click(object sender, EventArgs e)
        {
            AbrirForm(new dashboard());
        }

        private void citasbtn_Click(object sender, EventArgs e)
        {
            AbrirForm(new citas());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new historialmed());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AbrirForm(new Empleados());
        }

        private void pdad_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
