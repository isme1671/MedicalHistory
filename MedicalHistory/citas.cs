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
    public partial class citas : Form
    {
        public citas()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void citas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.citas' table. You can move, or remove it, as needed.
            this.citasTableAdapter.Fill(this.clinicaDataSet.citas);
            CargarPacientes();
            CargarEmpleados();
            CargarCitas();

        }
        private void CargarPacientes()
        {
            Conexion.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("SELECT id_paciente, nombre FROM pacientes", Conexion.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbpacientes.DataSource = dt;
            cbpacientes.DisplayMember = "nombre";
            cbpacientes.ValueMember = "id_paciente";
        }
        private void CargarEmpleados()
        {
            Conexion.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("SELECT id_empleado, nombre FROM empleados", Conexion.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbmedico.DataSource = dt;
            cbmedico.DisplayMember = "nombre";
            cbmedico.ValueMember = "id_empleado";
        }
        private void CargarCitas()
        {
            Conexion.Conectar();
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT c.id_gestion_empleados, p.nombre AS Paciente, e.nombre AS Empleado, c.fecha_cita, c.dia, c.id_historial_medico " +
                "FROM citas c " +
                "INNER JOIN pacientes p ON c.id_paciente = p.id_paciente " +
                "INNER JOIN empleados e ON c.id_empleado = e.id_paciente", Conexion.Conectar());

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvcitas.DataSource = dt;
        }
       

        private void btagregar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Conectar();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO citas (id_paciente, fecha_cita, dia, id_historial_medico, id_empleado) " +
                    "VALUES (@id_paciente, @fecha_cita, @dia, @id_historial_medico, @id_empleado)", Conexion.Conectar());

                cmd.Parameters.AddWithValue("@id_paciente", cbpacientes.SelectedValue);
                cmd.Parameters.AddWithValue("@fecha_cita", dtfecha.Value.Date);
                cmd.Parameters.AddWithValue("@dia", dthora.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@id_historial_medico", tbhis.Text);
                cmd.Parameters.AddWithValue("@id_empleado", cbmedico.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cita registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Conexion.Conectar();
                CargarCitas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la cita: " + ex.Message);
            }

        }
        private void LimpiarCampos()
        {
            tbhis.Clear();
            cbpacientes.SelectedIndex = -1;
            cbmedico.SelectedIndex = -1;
        }

        private void dgvcitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvcitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvcitas.Rows[e.RowIndex];
                cbpacientes.SelectedValue = fila.Cells["id_paciente"].Value.ToString();
                cbmedico.SelectedValue = fila.Cells["id_empleado"].Value.ToString();
                dtfecha.Value = Convert.ToDateTime(fila.Cells["fecha_cita"].Value);
                dthora.Value = DateTime.Today.Add(TimeSpan.Parse(fila.Cells["dia"].Value.ToString()));
                tbhis.Text = fila.Cells["id_historial_medico"].Value.ToString();
            }
        }
    }
}

