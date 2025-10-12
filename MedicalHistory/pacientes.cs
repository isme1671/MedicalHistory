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

        public DataTable actualizarp()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM pacientes order by id_paciente desc";
            SqlCommand commd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(commd);
            da.Fill(dt);
            return dt;
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO pacientes(nombre,apellido,cedula,edad,direccion,telefono,correo,id_historial_medico)Values(@nombre,@apellido,@cedula,@edad,@direccion,@telefono,@correo,@id_historial_medico)";
            SqlCommand comando1 = new SqlCommand(insertar,Conexion.Conectar());
            comando1.Parameters.AddWithValue("@nombre", tbnombrep.Text);
            comando1.Parameters.AddWithValue("@apellido", apellidotb.Text);
            comando1.Parameters.AddWithValue("@cedula", cedulatb.Text);
            comando1.Parameters.AddWithValue("@edad", int.Parse(edadtb.Text));
            comando1.Parameters.AddWithValue("@direccion", direcciontb.Text);
            comando1.Parameters.AddWithValue("@telefono", telefonotb.Text);
            comando1.Parameters.AddWithValue("@correo", tbcorreo.Text);
            comando1.Parameters.AddWithValue("@id_historial_medico", int.Parse(tbhistorial.Text));
            comando1.ExecuteNonQuery();
            dgvpacientes.DataSource = actualizarp();
            MessageBox.Show("Los datos han sido agregados.");
        }
    }
}
