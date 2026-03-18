using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestión_de_Parqueadero_ParkingPro.Interfaces;

namespace Gestión_de_Parqueadero_ParkingPro.Modelos
{
    public class Carro : Vehiculo, ICobrable
    {
        public int NroPuertas {  get; set; }

        public Carro(string placa, string marca, int nroPuertas) : base (placa, marca)
        {
            NroPuertas = nroPuertas;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Numero de puertas: " + NroPuertas);
        }

        public double CalcularTarifa(int minutos)
        {
            return 100.0 * minutos;
        }
    }
}
