using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace MedicalHistory
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("server=LAPTOP-ISMELIN; Database= clinica; Integrated Security= True");
            cn.Open();
            return cn;
        }
    }
}
