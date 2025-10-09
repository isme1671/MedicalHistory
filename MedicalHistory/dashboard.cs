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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void heartbt_Click(object sender, EventArgs e)
        {
            picbody.Image = Image.FromFile(Application.StartupPath + @"\Resources\corazond.jpeg");


        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            picbody.Image = Image.FromFile(Application.StartupPath + @"\Resources\corazond.jpeg");
        }

        private void pulmbt_Click(object sender, EventArgs e)
        {
            picbody.Image = Image.FromFile(Application.StartupPath + @"\Resources\pulmonesd.jpeg");
        }

        private void cerebt_Click(object sender, EventArgs e)
        {
            picbody.Image = Image.FromFile(Application.StartupPath + @"\Resources\cerebrod.jpeg");
        }

        private void cuerpbt_Click(object sender, EventArgs e)
        {
            picbody.Image = Image.FromFile(Application.StartupPath + @"\Resources\cuerpod.jpeg");
        }

        private void piesbt_Click(object sender, EventArgs e)
        {
            picbody.Image = Image.FromFile(Application.StartupPath + @"\Resources\piesd.jpeg");
        }
    }
}
