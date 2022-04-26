using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Clases
{
    class clsConexion
    {
        public static SqlConnection obtenerConexion()
        {
            
                SqlConnection conn = new SqlConnection("Data source = SALOME\\SQLEXPRESS; Initial catalog = DB_SISTEMA_PARQUEO; Integrated Security = True");
            try
            {
                conn.Open();
               
            }
            catch(Exception error)
            {
                
                Console.WriteLine("error con la conexion a la base de datos"+error.Message);
            }
            return conn;




        }
    }
}
