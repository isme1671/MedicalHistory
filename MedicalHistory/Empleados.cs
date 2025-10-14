using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MedicalHistory.Modelo;

namespace MedicalHistory
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }
        EmpleadosSql em = new EmpleadosSql();
        private void Empleados_Load(object sender, EventArgs e)
        {
            cmbocupacion.DataSource = em.Ocupaciones();
            cmbocupacion.DisplayMember = "ocupacion";
            cmbocupacion.ValueMember = "id_ocupacion";

            cmbespecialidad.DataSource = em.Especialidad();
            cmbespecialidad.DisplayMember = "especialidad";
            cmbespecialidad.ValueMember = "id_especialidad";
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int edad;
            int idOcupacion;
            int idEspecialidad;
            decimal sueldo;
            DateTime fecha = DateTime.Now; // La fecha de entrada se genera automáticamente

            // 2. Extracción de variables simples (strings)
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string cedula = txtcedula.Text;
            string direccion = txtdireccion.Text;
            string telefono = txttelefono.Text;
            string correo = txtcorreo.Text;
            string usuario = txtusuario.Text;
            string clave = txtclave.Text;

            // ELIMINADA la línea de inserción con Convert.ToXXX, ya que estaba duplicada y causaba errores
            // em.Insertar(txtnombre.Text, txtapellido.Text, txtcedula.Text, Convert.ToInt32(txtedad.Text), txtdireccion.Text, txttelefono.Text, txtcorreo.Text, Convert.ToInt32(cmbocupacion.SelectedValue), Convert.ToInt32(cmbespecialidad.SelectedValue), fecha, Convert.ToDecimal(txtsueldo.Text), txtusuario.Text, txtclave.Text);

            // --- 3. VALIDACIÓN Y CONVERSIÓN SEGURA (usando TryParse) ---

            // A. Edad (INT)
            // Usar 'txtedad.Text' en lugar de 'txtEdad.Text' por consistencia con tu llamada original
            if (!int.TryParse(txtedad.Text, out edad))
            {
                MessageBox.Show("Error: La Edad debe ser un número entero válido.", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // B. Sueldo (DECIMAL) - Usamos InvariantCulture para aceptar el punto '.' como separador decimal.
            // Si quieres usar coma ',', ajusta NumberStyles y CultureInfo.
            if (!decimal.TryParse(txtsueldo.Text,
                                  System.Globalization.NumberStyles.Currency,
                                  System.Globalization.CultureInfo.InvariantCulture,
                                  out sueldo))
            {
                MessageBox.Show("Error: El Sueldo debe ser un valor numérico. Use el punto '.' como separador decimal si es necesario.", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // C. ID Ocupación (INT) - Asume que el SelectedValue es un string que se puede parsear.
            if (cmbocupacion.SelectedValue == null || !int.TryParse(cmbocupacion.SelectedValue.ToString(), out idOcupacion))
            {
                MessageBox.Show("Error: Debe seleccionar una Ocupación válida.", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // D. ID Especialidad (INT) - Asume que el SelectedValue es un string que se puede parsear.
            if (cmbespecialidad.SelectedValue == null || !int.TryParse(cmbespecialidad.SelectedValue.ToString(), out idEspecialidad))
            {
                MessageBox.Show("Error: Debe seleccionar una Especialidad válida.", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // E. (Opcional) Validación de campos de texto obligatorios
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Los campos Nombre y Clave son obligatorios.", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

      
            }


            // --- 4. LLAMADA AL MÉTODO DE INSERCIÓN (Si todas las conversiones fueron exitosas) ---
            try
            {
                // El método Insertar usa ahora los valores ya convertidos
                em.Insertar(nombre, apellido, cedula, edad, direccion, telefono, correo,
                                  idOcupacion, idEspecialidad, fecha, sueldo, usuario, clave);

                MessageBox.Show("Se ha registrado al empleado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Aquí podrías añadir un método para limpiar los campos
                EmpleadoList aform = new EmpleadoList();
                aform.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                // Captura cualquier error que ocurra *después* de la validación (ej. error de SQL Server)
                MessageBox.Show("Ocurrió un error en la base de datos o en la conexión: " + ex.Message, "Error de Inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btlista_Click(object sender, EventArgs e)
        {
            inicio iniciom = (inicio)this.ParentForm;
            iniciom.abrirfrms(new EmpleadoList());
        }
    }
}
