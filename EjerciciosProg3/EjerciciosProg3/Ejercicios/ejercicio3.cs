//Control de Aforo en Eventos: Una discoteca tiene un aforo máximo de 50
//personas. Crea un programa que pregunte cuántas personas quieren entrar. Si hay
//cupo, dales la bienvenida; si no, indícales cuántas personas deben salir para
//que ellos puedan entrar.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProg3.Ejercicios
{
    internal class ejercicio3
    {
        public static void Ejecutar()
        {
          
            int maximoPer = 50;
            Console.WriteLine("Cuantas personas desean entrar?");
            int entrada = int.Parse(Console.ReadLine());

            if (entrada <= maximoPer)
            {
                Console.WriteLine("Bienvenidos");
            }
            else
            {
                int negado = entrada - maximoPer;
                Console.WriteLine("Para poder entrar deben salir este total de personas: " + negado);
            }
        }
    }
}
