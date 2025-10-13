using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalHistory.Modelo
{
    public class EmpleadosSql
    {
        public DataTable Ocupaciones()
        {
            Conexion.Conectar();
            string query = "select * from ocupacion";
            SqlDataAdapter data = new SqlDataAdapter(query, Conexion.Conectar());
            data.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
            
        }

        public DataTable Especialidad()
        {
            Conexion.Conectar();
            string query = "select * from especialidad";
            SqlDataAdapter data = new SqlDataAdapter(query, Conexion.Conectar());
            data.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;

        }

        public DataTable Mostrar()
        {
            Conexion.Conectar();
            string query = "select e.nombre, e.apellido, e.cedula, e.edad, e.correo, o.ocupacion from empleados as e join ocupacion as o \r\non e.id_ocupacion = o.id_ocupacion";
            SqlDataAdapter data = new SqlDataAdapter(query, Conexion.Conectar());
            data.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;

        }

        public void Insertar(string nombre, string apellido, string cedula, int edad, string direccion, string telefono, string correo, int idO, int idE, DateTime fecha, decimal sueldo, string usuario, string clave )
        {
            Conexion.Conectar();
            string query = @"
        INSERT INTO empleados (
            nombre, apellido, cedula, edad, direccion, telefono, correo, 
            id_ocupacion, id_especialidad, fecha_entrada, sueldo, usuario, clave
        ) VALUES (
            @nombre, @apellido, @cedula, @edad, @direccion, @telefono, @correo, 
            @id_ocupacion, @id_especialidad, @fecha_entrada, @sueldo, @usuario, @clave
        )";
            SqlCommand cm = new SqlCommand(query, Conexion.Conectar());
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@nombre", nombre);
            cm.Parameters.AddWithValue("@apellido", apellido);
            cm.Parameters.AddWithValue("@cedula", cedula);
            cm.Parameters.AddWithValue("@edad", edad);                     // INT, sin comillas
            cm.Parameters.AddWithValue("@direccion", direccion);
            cm.Parameters.AddWithValue("@telefono", telefono);
            cm.Parameters.AddWithValue("@correo", correo);
            cm.Parameters.AddWithValue("@id_ocupacion", idO);       // INT
            cm.Parameters.AddWithValue("@id_especialidad", idE);    // INT
            cm.Parameters.AddWithValue("@fecha_entrada", fecha);     // DateTime (Soluciona problemas de formato)
            cm.Parameters.AddWithValue("@sueldo", sueldo);                 // DECIMAL
            cm.Parameters.AddWithValue("@usuario", usuario);
            cm.Parameters.AddWithValue("@clave", clave);
            int r = cm.ExecuteNonQuery();
            string mensaje = null;
            if (r > 0)
            {
                mensaje = "excelente";
            }
            else
            {
                mensaje = "error";
            } 
            Conexion.Cerrar();
        }
    }
}
