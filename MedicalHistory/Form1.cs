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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void accederbtn_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();

            if(usuarios.autorizacion(tbtuser.Text, tbtpass.Text) == true)
            {
                if(User.IdOcupacion == 1)
                {
                    inicio aform = new inicio();
                    aform.Show();
                    aform.btnpacientes.Enabled = true;
                    MessageBox.Show("Bienvenido " + User.NombreOcupacion);
                }
                else if(User.IdOcupacion == 2)
                {
                    inicio aform = new inicio();
                    aform.Show();
                    aform.btnmedicos.Enabled = false;
                    aform.btnmedicos.BackColor = Color.Gray;

                    MessageBox.Show("Bienvenido " + User.NombreOcupacion);

                }
                else
                {
                    inicio aform = new inicio();
                    aform.Show();
                    aform.btnmedicos.Enabled = false;
                    aform.btnmedicos.BackColor = Color.Gray;

                    aform.btnconfi.Enabled = false;
                    aform.btnconfi.BackColor = Color.Gray;

                    aform.btnusuarios.Enabled = false;
                    aform.btnusuarios.BackColor = Color.Gray;
                    MessageBox.Show("Bienvenido" + User.NombreOcupacion);
                }
              
            }
        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
