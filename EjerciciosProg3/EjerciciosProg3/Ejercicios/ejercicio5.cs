//Simulador de Semáforo Inteligente: Pide al usuario que ingrese el color actual
//del semáforo (Verde, Amarillo, Rojo). Si es verde, imprime "Sigue adelante";
//si es amarillo, "Prepárate para frenar"; y si es rojo, "¡Detente!".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProg3.Ejercicios
{
    internal class ejercicio5
    {
        public static void Ejecutar()
        {

            Console.WriteLine("Ingrese el color acutal del semaforo (verde, amarillo, rojo)");
            String colorSem = Console.ReadLine().ToLower();

            if (colorSem == "verde")
            {
                Console.WriteLine("Sigue adelante");
            }
            else if (colorSem == "amarillo")
            {
                Console.WriteLine("Preparate para frenar");
            }
            else if (colorSem == "rojo")
            {
                Console.WriteLine("Detente");
            }
            else
            {
                Console.WriteLine("Ingresaste un color no valido");
            }
        }
    }
}
