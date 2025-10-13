using MedicalHistory.Modelo;
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
    public partial class EmpleadoList : Form
    {
        public EmpleadoList()
        {
            InitializeComponent();

            EmpleadosSql em = new EmpleadosSql();

            dgem.DataSource = em.Mostrar();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Empleados em = new Empleados();
            em.Show();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

        }
    }
}
