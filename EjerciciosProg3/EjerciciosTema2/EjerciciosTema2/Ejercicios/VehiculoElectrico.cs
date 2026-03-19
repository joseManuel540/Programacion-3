///Control de Vehículos Eléctricos: Crea una clase VehiculoElectrico con un nivel 
///de batería. Implementa un método Viajar(int km) que reste 1% de batería por cada
///kilómetro. Si la batería llega a 0, el coche debe avisar que necesita carga 
///inmediata.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema2.Ejercicios
{
    internal class VehiculoElectrico
    {
        public int NivelBateria { get; set; }

        public void Viajar(int km)
        {
            NivelBateria = NivelBateria - km;

            if (NivelBateria <= 0)
            {
                NivelBateria = 0;
                Console.WriteLine("Bateria agotada, necesita carga inmediata.");
            }
            else
            {
                Console.WriteLine("Se completo el viaje");
            }

        }


    }
}
