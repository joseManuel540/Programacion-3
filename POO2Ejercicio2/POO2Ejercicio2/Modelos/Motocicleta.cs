using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO2Ejercicio2.Interfaces;

namespace POO2Ejercicio2.Modelos
{
    public class Motocicleta : Vehiculo, IVendible
    {
        public decimal CalcularComisionVendedor()
        {
            throw new NotImplementedException();
        }

        public decimal CalcularPrecioFinal()
        {
            throw new NotImplementedException();
        }

        public void GenerarFacturaVenta()
        {
            throw new NotImplementedException();
        }
    }
}
