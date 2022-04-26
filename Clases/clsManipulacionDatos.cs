using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class clsManipulacionDatos
    {
        private int id;
        private string nombreM;
        private string apellidoM;
        private int numeroLicenciaM;
        private int numeroPlacaM;
        private string colorM;
        private string tipoVehiculoM;
        private string horaentradaM;
        private int horasEstacioandoM;
        private double tarifaHoraM;

        public int Id { get => id; set => id = value; }
        public string NombreM { get => nombreM; set => nombreM = value; }
        public string ApellidoM { get => apellidoM; set => apellidoM = value; }
        public int NumeroLicenciaM { get => numeroLicenciaM; set => numeroLicenciaM = value; }
        public int NumeroPlacaM { get => numeroPlacaM; set => numeroPlacaM = value; }
        public string ColorM { get => colorM; set => colorM = value; }
        public string TipoVehiculoM { get => tipoVehiculoM; set => tipoVehiculoM = value; }
        public string HoraentradaM { get => horaentradaM; set => horaentradaM = value; }
        public int HorasEstacioandoM { get => horasEstacioandoM; set => horasEstacioandoM = value; }
        public double TarifaHoraM { get => tarifaHoraM; set => tarifaHoraM = value; }
        

        public clsManipulacionDatos()
        {

        }

        clsManipulacionDatos(int pId, string pNombre, string pApellido, int pNumeroLicencia, int pNumeroPlaca, string pColor, string pTipoVehiculo, string pHoraEntrada, int pHorasEstacionado, double pTarifaHora)
        {
            this.Id = pId;
            this.NombreM = pNombre;
            this.ApellidoM = pApellido;
            this.NumeroLicenciaM = pNumeroLicencia;
            this.NumeroPlacaM = pNumeroPlaca;
            this.ColorM = pColor;
            this.TipoVehiculoM = pTipoVehiculo;
            this.HoraentradaM = pHoraEntrada;
            this.HorasEstacioandoM = pHorasEstacionado;
            this.TarifaHoraM = pTarifaHora;

        }
    }
}
