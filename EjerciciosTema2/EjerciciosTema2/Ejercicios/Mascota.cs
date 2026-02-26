using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema2.Ejercicios
{
    internal class Mascota
    {   
        public string Nombre { get; set; }
        public virtual void HacerTruco()
        {
            Console.WriteLine("La mascota hizo un truco");
        }
    }

    class Loro : Mascota
    {
        public override void HacerTruco()
        { 
            Console.WriteLine("El loro dice hola");
        }
    }

    class Gato : Mascota
    {
        public override void HacerTruco()
        {
            Console.WriteLine("El gato esta amasando pan");
        }
    }
}
