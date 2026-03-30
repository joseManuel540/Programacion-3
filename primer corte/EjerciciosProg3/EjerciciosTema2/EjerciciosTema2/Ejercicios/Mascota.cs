///Sistema de Mascotas Virtuales: Crea una clase base Mascota con un nombre y un 
///método HacerTruco(). Crea clases derivadas como Loro (que repita una frase) y
///Gato (que amase pan). Usa una lista para que el usuario elija qué mascota quiere
///ver actuar.

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
