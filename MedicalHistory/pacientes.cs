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
        private void LimpiarCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
            }
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
            LimpiarCampos();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = Conexion.Conectar();

                string query = "UPDATE pacientes SET nombre = @nombre, apellido = @apellido, cedula = @cedula, edad = @edad, direccion = @direccion , telefono = @telefono, correo = @correo, id_historial_medico = @id_historial_medico " +
                               "WHERE id_paciente = @id_paciente";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id_paciente", tbid.Text);
                cmd.Parameters.AddWithValue("@nombre", tbnombrep.Text);
                cmd.Parameters.AddWithValue("@apellido", apellidotb.Text);
                cmd.Parameters.AddWithValue("@cedula", cedulatb.Text);
                cmd.Parameters.AddWithValue("@edad", int.Parse(edadtb.Text));
                cmd.Parameters.AddWithValue("@direccion", direcciontb.Text);
                cmd.Parameters.AddWithValue("@telefono", telefonotb.Text);
                cmd.Parameters.AddWithValue("@correo", tbcorreo.Text);
                cmd.Parameters.AddWithValue("@id_historial_medico", int.Parse(tbhistorial.Text));

                cmd.ExecuteNonQuery();

                dgvpacientes.DataSource = actualizarp();
                MessageBox.Show("Datos actualizados correctamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
            LimpiarCampos();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminará el registro?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conexion.Conectar();
                string eliminar = "Delete from pacientes where id_paciente = @id_paciente";
                SqlCommand comd5 = new SqlCommand(eliminar, Conexion.Conectar());
                comd5.Parameters.AddWithValue("@id_paciente", tbid.Text);
                comd5.ExecuteNonQuery();
                dgvpacientes.DataSource = actualizarp();
            }
        }

        private void tbid_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)(Keys.Enter))
            {
                Conexion.Conectar();
                string csqls = "select*from pacientes where id_paciente=" + tbid.Text + "";
                SqlCommand comd2 = new SqlCommand(csqls, Conexion.Conectar());
                SqlDataReader leer = comd2.ExecuteReader();
                if (leer.Read() == true)
                {
                    tbnombrep.Text = leer["nombre"].ToString();
                    apellidotb.Text = leer["apellido"].ToString();
                    cedulatb.Text = leer["cedula"].ToString();
                    edadtb.Text = leer["edad"].ToString();
                    direcciontb.Text = leer["direccion"].ToString();
                    telefonotb.Text = leer["telefono"].ToString();
                    tbcorreo.Text = leer["correo"].ToString();
                    tbhistorial.Text = leer["id_historial_medico"].ToString();

                }
                else
                {
                    tbnombrep.Text = "No encontrado";
                }
                e.Handled = true;
                SendKeys.Send("");
            }
            LimpiarCampos();
        }
    }
    }

