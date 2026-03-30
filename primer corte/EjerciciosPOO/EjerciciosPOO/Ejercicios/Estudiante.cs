///3. Calculadora de Calificaciones (Clase Estudiante)
//Objetivo: Procesar las notas de un alumno.

//Clase: Estudiante.
//Propiedades: Nombre, Materia y una lista o arreglo de Notas (3 parciales).
//Métodos:
//CalcularPromedio(): Devuelve el promedio de las 3 notas.
//EstadoFinal(): Devuelve "Aprobado" si el promedio es >= 3.0 o "Reprobado" de lo contrario.
//Interacción: El usuario ingresa el nombre del estudiante, la materia y las 3 notas una por una. Al
//final, el programa muestra el promedio y el estado.
using System.Diagnostics;
using EjerciciosPOO.Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Ejercicios
{
    internal class Estudiante
    {
        public String Nombre { get; set; }
        public String Materia { get; set; }

        public double[] Notas { get; set; }

        public Estudiante() 
        {
            Notas = new double[3];
        }
        
        public double CalcularPromedio()
        {
            double suma = 0;

            for (int i = 0; i < Notas.Length; i++)
            {
                suma = suma + Notas[i];
            }

            return (suma/Notas.Length);
        }

        public String EstadoFinal()
        {
            double promedio = CalcularPromedio();
            if (promedio >= 3.0)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }

        public static void Ejecutar()
        {
            Console.WriteLine("EJERCICIO #3");
            Estudiante estudiante = new Estudiante();
            Console.WriteLine("Ingrese el nombre del estudiante: ");
            estudiante.Nombre = Console.ReadLine();

            for (int i = 0; i < estudiante.Notas.Length; i++)
            {
                Console.WriteLine("Ingrese la nota #" + (i + 1));
                estudiante.Notas[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Promedio estudiante: ");
            Console.WriteLine(estudiante.CalcularPromedio());
            Console.WriteLine("Estado del estudiante: ");
            Console.WriteLine(estudiante.EstadoFinal());

        }

    }
}
