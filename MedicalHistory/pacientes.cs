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
    public partial class pacientes : Form
    {
        public pacientes()
        {
            InitializeComponent();
        }

        private void pacientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.pacientes' table. You can move, or remove it, as needed.
            this.pacientesTableAdapter.Fill(this.clinicaDataSet.pacientes);

        }
    }
}
