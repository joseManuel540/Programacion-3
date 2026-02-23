using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProg3.Ejercicios
{
    internal class ejercicio2
    {
        public static void Ejecutar()
        {
            //Calculadora de Propina Solidaria: Pide el total de una cuenta en un
            //restaurante. Pregunta qué porcentaje de propina desea dejar (10%, 15% o 20%).
            //Si el total con propina supera los $100.000, muestra un mensaje agradeciendo
            //su generosidad.

            Console.WriteLine("Ingrese el total de la cuenta: ");
            double cuenta = double.Parse(Console.ReadLine());
            Console.WriteLine("Que porcentaje de propina desea dejar? (10,20,30...)");
            int propina = int.Parse(Console.ReadLine());

            double propinaTotal = cuenta * (propina / 100.0);

            if (propinaTotal + cuenta >= 100000)
            {
                Console.WriteLine("Gracias por su generosidad");
            }
            else
            {
                Console.WriteLine("Gracias por visitarnos");
            }
        }
    }
}
