using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Clases;
using System.Security.Cryptography.X509Certificates;



namespace Clases
{
    public class clsMantenimientoLogin
    {
        public static int agregarNuevoLogin(clsNuevoLogin pLogin)//recive la clase nuevo login y asigna un parametro de indetificacion 
        {
            int retorno = 0;
            

                using (SqlConnection conn = clsConexion.obtenerConexion())//CREAR PROCEDIMIENTO ALMACENADO 
                {
                    /* SqlCommand comando = new SqlCommand(String.Format("INSERT INTO NUEVO_LOGIN(NOMBRE, APELLIDO, CORREO, PASS) VALUES( '{0}','{1}','{2}','{3}')", pLogin.Nombre, pLogin.Apellido, pLogin.Correo, pLogin.Pass), conn);
                     retorno = comando.ExecuteNonQuery();*/
                    SqlCommand comando = new SqlCommand(string.Format("EXEC spNUEVO_LOGIN '{0}','{1}','{2}','{3}','{4}' ", pLogin.Nombre, pLogin.Apellido, pLogin.Correo, pLogin.Pass, pLogin.Usuario), conn);
                    retorno = comando.ExecuteNonQuery();
                }
                return retorno;
            
        }

    //obtener 
        public int login(string usuario, string pass)
        {
            try
            {
                using(SqlConnection conn = clsConexion.obtenerConexion() )
                {
                    SqlCommand cmd = new SqlCommand("spLogin", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if(dr.Read())
                    {
                        return dr.GetInt32(0);
                    }
                    conn.Close();
                }
            }
            catch (Exception e)
            {
               
            }
            return -1;
            
        }

        



    }
}
