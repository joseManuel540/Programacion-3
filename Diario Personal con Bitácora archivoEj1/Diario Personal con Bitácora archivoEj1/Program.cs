/*Diario Personal con Bitácora (Clase File y DateTime)
Objetivo: Crear un programa que permita al usuario escribir una entrada en su "diario" y 
guardarla automáticamente con la fecha y hora actual.

Instrucciones:

Solicita al usuario que ingrese su nombre al iniciar.
Pide al usuario que escriba un pensamiento o actividad del día por teclado.
Guarda el texto en un archivo llamado diario.txt.
Regla de oro: No debes sobrescribir lo anterior. Usa File.AppendAllText.
El formato de cada línea en el archivo debe ser: [FECHA Y HORA] - USUARIO: MENSAJE.
Reto extra: Al iniciar el programa, muestra las últimas 3 líneas guardadas en el diario antes
de pedir una nueva entrada.*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diario_Personal_con_Bitácora_archivoEj1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DateTime fecha = DateTime.Now;
            string ruta = "diario.txt";

            if (File.Exists(ruta))
            {
                Console.WriteLine("\nÚltimas entradas del diario:");

                string[] lineas = File.ReadAllLines(ruta);

                foreach (string linea in lineas.Take(3))
                {
                    Console.WriteLine(linea);
                }
            }
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba un pensamiento o actividad de su dia: ");
            string pensamiento = Console.ReadLine();
            File.AppendAllText(ruta, $"[{fecha}] - {nombre}: {pensamiento} {Environment.NewLine}");

        }
    }
}
