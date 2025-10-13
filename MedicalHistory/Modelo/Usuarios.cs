using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalHistory.Modelo
{
    public class Usuarios
    {
       
        public bool autorizacion(string user, string clave)
        {
            Conexion.Conectar();
            
            
            string query = @"
            SELECT 
                E.id_empleado, 
                E.usuario, 
                O.id_ocupacion, 
                O.ocupacion 
            FROM empleados E
            INNER JOIN ocupacion O ON E.id_ocupacion = O.id_ocupacion
            WHERE E.usuario = @Usuario AND E.clave = @Clave";
            // NOTA: En un entorno real, la clave NUNCA se almacenaría en texto plano. Se usaría hashing (ej. SHA256).

            using (Conexion.Conectar())
            {
                SqlCommand command = new SqlCommand(query, Conexion.Conectar());

                // Usamos parámetros para prevenir inyección SQL
                command.Parameters.AddWithValue("@Usuario", user);
                command.Parameters.AddWithValue("@Clave", clave);

                try
                {
                    Conexion.Conectar();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // 1. Autenticación exitosa

                        // 2. Almacenamiento de la información para la Sesión (Autorización)
                        User.IdEmpleado = reader.GetInt32(0);
                        User.NombreUsuario = reader.GetString(1);
                        User.IdOcupacion = reader.GetInt32(2);
                        User.NombreOcupacion = reader.GetString(3);

                        return true;
                    }
                    else
                    {
                        // Usuario o clave incorrecta
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores de conexión o SQL
                    System.Windows.Forms.MessageBox.Show("Error de conexión/SQL: " + ex.Message, "Error Crítico", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
    
}
