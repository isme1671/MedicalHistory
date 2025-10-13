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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            EmpleadosSql em = new EmpleadosSql();
            if (dgem.SelectedRows.Count == 1){
               
                int id = Convert.ToInt32(dgem.CurrentRow.Cells[0].Value);
                 em.Eliminar(id);

                em.Mostrar();
                MessageBox.Show("Se elimino el empleado");
 
            }
        }
    }
}
