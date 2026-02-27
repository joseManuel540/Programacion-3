//Generador de Correos Corporativos: Pide al usuario su nombre y apellido.
//El programa debe generar un correo con el formato nombre.apellido@empresa.com
//(todo en minúsculas).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProg3.Ejercicios
{
    internal class ejercicio4
    {
        public static void Ejecutar()
        {

            Console.WriteLine("Ingrese su PRIMER nombre: ");
            String primerNom = Console.ReadLine().ToLower();
            Console.WriteLine("Ingrese su PRIMER apellido: ");
            String primerApe = Console.ReadLine().ToLower();

            Console.WriteLine("Su correo es: ");
            Console.WriteLine(primerNom + primerApe + "@empresa.com");
        }
    }
}
