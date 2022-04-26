using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
//using System.Windows.Forms;

namespace Clases
{
   public class clsMantenimiento
    {
        public static int agregarUsuarios( clsRegistrar pRegistro)
        {
            int retorno = 0;

            using (SqlConnection conn = clsConexion.obtenerConexion())
            {
                // SqlCommand comando = new SqlCommand(string.Format("EXEC spENCARGADO '{0}','{1}','{2}' ", pRegistro.Nombre, pRegistro.Apellidos, pRegistro.Licencia), conn);
                //   comando = new SqlCommand(string.Format("EXEC spVEHICULO '{0}','{1}','{2}' ", pRegistro.NumeroPlaca, pRegistro.TipoVehiculo, pRegistro.Color), conn);
                //    comando = new SqlCommand(string.Format("EXEC spDETALLES '{0}','{1}','{2}' ", pRegistro.HoraEntrada, pRegistro.CantidadHoras, pRegistro.TarifaHora), conn);
                 SqlCommand comando = new SqlCommand(string.Format("EXEC spREGISTRO '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}' ", pRegistro.Nombre, pRegistro.Apellidos, pRegistro.Licencia, pRegistro.NumeroPlaca, pRegistro.TipoVehiculo, pRegistro.Color, pRegistro.HoraEntrada, pRegistro.CantidadHoras, pRegistro.TarifaHora), conn);

                retorno = comando.ExecuteNonQuery();

            }
            return retorno;
        }

        public static List<clsManipulacionDatos> buscarInformacion(int placa)
        {
            List<clsManipulacionDatos> lista = new List<clsManipulacionDatos>();
            using(SqlConnection conexion =  clsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("EXEC spOBTENER_DATOS '{0}'", placa), conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    //convertir todos los campos de cb a tb
                    clsManipulacionDatos campoRegistroObj = new clsManipulacionDatos();
                    campoRegistroObj.Id = reader.GetInt32(0);
                    campoRegistroObj.NombreM = Convert.ToString(reader.GetString(1));
                    campoRegistroObj.ApellidoM = Convert.ToString(reader.GetString(2));
                    campoRegistroObj.NumeroLicenciaM = reader.GetInt32(3);
                    campoRegistroObj.NumeroPlacaM = reader.GetInt32(4);
                    campoRegistroObj.ColorM = Convert.ToString(reader.GetString(5));
                    campoRegistroObj.TipoVehiculoM = Convert.ToString(reader.GetString(6));
                    campoRegistroObj.HoraentradaM = Convert.ToString(reader.GetString(7));
                    campoRegistroObj.HorasEstacioandoM = reader.GetInt32(8);
                    campoRegistroObj.TarifaHoraM = Decimal.ToDouble(reader.GetDecimal(9));
                    
                    
                    lista.Add(campoRegistroObj);
                }
                conexion.Close();
                return lista;
               
            }
            
        }

        //seleccionando informacion
        public static clsManipulacionDatos obtenerDatos(Int64 idN)
        {
            clsManipulacionDatos campoRegistroObj = new clsManipulacionDatos();

            using (SqlConnection conexion =  clsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("EXEC spEXPORTAR_DATOS '{0}'", idN), conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    //convertir todos los campos de cb a tb
                    campoRegistroObj.Id = reader.GetInt32(0);
                    campoRegistroObj.NombreM = Convert.ToString(reader.GetString(1));
                    campoRegistroObj.ApellidoM = Convert.ToString(reader.GetString(2));
                    campoRegistroObj.NumeroLicenciaM = reader.GetInt32(3);
                    campoRegistroObj.NumeroPlacaM = reader.GetInt32(4);
                    campoRegistroObj.ColorM = Convert.ToString(reader.GetString(5));
                    campoRegistroObj.TipoVehiculoM = Convert.ToString(reader.GetString(6));
                    campoRegistroObj.HoraentradaM = Convert.ToString(reader.GetString(7));
                    campoRegistroObj.HorasEstacioandoM = reader.GetInt32(8);
                    campoRegistroObj.TarifaHoraM = Decimal.ToDouble(reader.GetDecimal(9));
                    
                    
                }
                conexion.Close();
                return campoRegistroObj;
               
            }
            
        }

        //actualizar informacion
        public static int actualizarUsuarios( clsManipulacionDatos pActualizar )
        {
            int retorno = 0;

            using (SqlConnection conn = clsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("EXEC spActualizar '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}' ",pActualizar.Id, pActualizar.NombreM, pActualizar.ApellidoM, pActualizar.NumeroLicenciaM, pActualizar.NumeroPlacaM, pActualizar.TipoVehiculoM, pActualizar.ColorM, pActualizar.HoraentradaM, pActualizar.HorasEstacioandoM, pActualizar.TarifaHoraM), conn);

                retorno = comando.ExecuteNonQuery();

            }
            return retorno;
        }


        public static int eliminarUsuarios(clsManipulacionDatos pEliminar)
        {
            int retorno = 0;

            using (SqlConnection conn = clsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("EXEC spELIMINAR '{0}' ", pEliminar.Id), conn);

                retorno = comando.ExecuteNonQuery();

            }
            return retorno;
        }

        //obtener flujo efectivo
        public static List<clsFlujoEFectivo> obtenerFlujo(int parametro)
        {
            List<clsFlujoEFectivo> lista = new List<clsFlujoEFectivo>();
            using (SqlConnection conexion = clsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("EXEC spDINEROTOTAL '{0}'", parametro), conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    //convertir todos los campos de cb a tb
                    clsFlujoEFectivo flujoDineroObj = new clsFlujoEFectivo();
                    flujoDineroObj.TotalDinero = Decimal.ToDouble(reader.GetDecimal(0));
                    flujoDineroObj.CantidadVehiculos = reader.GetInt32(1);
                   

                    lista.Add(flujoDineroObj);
                }
                conexion.Close();
                return lista;

            }

        }
    }
}
