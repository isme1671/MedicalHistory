using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public DataTable actualizarp()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM historial_medico order by id_historial_medico desc";
            SqlCommand commd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(commd);
            da.Fill(dt);
            return dt;
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
           
          
           
                Conexion.Conectar();
                string insertar = "INSERT INTO historial_medico(fecha_consulta,motivo_de_consulta,tratamiento,observacion,comentario)Values(@fecha_consulta,@motivo_de_consulta,@tratamiento,@observacion,@comentario)";
                SqlCommand comando1 = new SqlCommand(insertar, Conexion.Conectar());
                comando1.Parameters.AddWithValue("@fecha_consulta", Convert.ToDateTime(tbfcon.Text));
                comando1.Parameters.AddWithValue("@motivo_de_consulta", tbmotc.Text);
                comando1.Parameters.AddWithValue("@tratamiento", tbtrata.Text);
                comando1.Parameters.AddWithValue("@observacion", tbobs.Text);
                comando1.Parameters.AddWithValue("@comentario", tbcoment.Text);
                comando1.ExecuteNonQuery();
                dgvpacientes.DataSource = actualizarp();
                MessageBox.Show("Los datos han sido agregados.");
           
        }
    }
}
