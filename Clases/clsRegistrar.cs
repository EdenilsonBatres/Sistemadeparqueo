using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class clsRegistrar
    {
        private string nombre;
        private string apellidos;
        private int licencia;
        private int numeroPlaca;
        private string color;
        private string tipoVehiculo;
        private string horaEntrada;
        private int cantidadHoras;
        private double tarifaHora;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Licencia { get => licencia; set => licencia = value; }
        public int NumeroPlaca { get => numeroPlaca; set => numeroPlaca = value; }
        public string Color { get => color; set => color = value; }
        public string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
        public string HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public int CantidadHoras { get => cantidadHoras; set => cantidadHoras = value; }
        public double TarifaHora { get => tarifaHora; set => tarifaHora = value; }

        public clsRegistrar()
        {

        }

        public clsRegistrar(string pNombre, string pApellido, int pLicencia, int pNumeroPlaca, string pColor, string pTipoVehiculo, string pHoraEntrada, int pCantidad, int pTarifa )
        {
            this.Nombre = pNombre;
            this.Apellidos = pApellido;
            this.Licencia = pLicencia;
            this.NumeroPlaca = pNumeroPlaca;
            this.Color = pColor;
            this.TipoVehiculo = pTipoVehiculo;
            this.HoraEntrada = pHoraEntrada;
            this.CantidadHoras = pCantidad;
            this.TarifaHora = pTarifa;
        }
    }
}
