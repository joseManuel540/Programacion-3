using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Parqueadero_ParkingPro.Modelos
{
    public class Vehiculo
    {
        public string Placa {  get; set; }
        public string Marca { get; set; }

        protected Vehiculo(string placa, string marca) 
        {
            Placa = placa;
            Marca = marca;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Placa: " + Placa);
            Console.WriteLine("Marca : " + Marca);
        }
    }
}
