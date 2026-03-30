using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema2.Ejercicios
{
    internal class Podcast : IReproductor
    {
        public String Nombre { get; set; }
        public void Play()
        {
            Console.WriteLine("El podcast se esta reproducciendo");
        }

        public void Stop()
        {
            Console.WriteLine("La podcast se ha detenido");
        }
    }
}
