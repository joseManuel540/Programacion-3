using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema2.Ejercicios
{
    internal class Cancion : IReproductor
    {

        public String Nombre { get; set; }
        public void Play()
        {
            Console.WriteLine("La cancion se esta reproducciendo");
        }

        public void Stop()
        {
            Console.WriteLine("La cancion ha parado");
        }
    }
}
