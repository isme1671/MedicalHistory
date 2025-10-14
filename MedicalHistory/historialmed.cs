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
    public partial class historialmed : Form
    {
        public historialmed()
        {
            InitializeComponent();
        }

        private void historialmed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.historial_medico' table. You can move, or remove it, as needed.
            this.historial_medicoTableAdapter.Fill(this.clinicaDataSet.historial_medico);

        }
    }
}
