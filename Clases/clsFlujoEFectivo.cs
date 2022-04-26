using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class clsFlujoEFectivo
    {
        //private int parametro;
        private int cantidadVehiculos;
        private double totalDinero;

       // public int Parametro { get => parametro; set => parametro = value; }
        public int CantidadVehiculos { get => cantidadVehiculos; set => cantidadVehiculos = value; }
        public double TotalDinero { get => totalDinero; set => totalDinero = value; }

        public clsFlujoEFectivo()
        {

        }

        clsFlujoEFectivo(int pCantidadVehiculos, int pTotalDinero)
        {
          //  this.Parametro = pParametro;
            this.CantidadVehiculos = pCantidadVehiculos;
            this.TotalDinero = pTotalDinero;
        }
    }
}
