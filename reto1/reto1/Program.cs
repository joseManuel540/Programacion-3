using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime fechaActual = DateTime.Now;

            string ruta = "cumpleaños.txt";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el primer nombre");
                string n1 = Console.ReadLine();
                Console.WriteLine("Ingrese su fecha de nacimiento (año-mes-dia, xxxx-xx-xx)");
                string fecha1 = Console.ReadLine();
                DateTime f1 = DateTime.Parse(fecha1);

                DateTime cumpleaños = new DateTime(DateTime.Now.Year, f1.Month, f1.Day);
                TimeSpan faltan = cumpleaños - fechaActual;
                Console.WriteLine($"A {n1} le faltan {faltan.Days} días para su cumpleaños.");

                File.AppendAllText(ruta, $"{n1} - {f1}");

            }
            string contenido = File.ReadAllText(ruta);
            Console.WriteLine(contenido);



        }
    }
}
