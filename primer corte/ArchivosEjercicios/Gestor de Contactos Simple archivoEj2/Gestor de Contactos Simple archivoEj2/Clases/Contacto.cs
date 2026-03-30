using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Gestor_de_Contactos_Simple_archivoEj2.Clases
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string ToCSV() => $"{Nombre};{Telefono};{Correo}";

        public static void Ejecutar()
        {
            Contacto contacto = new Contacto();

            Console.WriteLine("ingrese un nombre");
            contacto.Nombre = Console.ReadLine().Trim();
            Console.WriteLine("Ingrese su telefono");
            contacto.Telefono = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Ingrese su correo");
            contacto.Correo = Console.ReadLine().Trim().ToLower();

            string ruta = "contactos.csv";
            File.AppendAllText(ruta, contacto.ToCSV() + Environment.NewLine);

            Console.WriteLine("Deseas listar contactos? (si/no)");
            string rta = Console.ReadLine().Trim().ToLower();

            if (rta == "si")
            {
                if (File.Exists(ruta))
                {
                    Console.WriteLine("\nCONTACTOS");
                    Console.WriteLine("------------------------------------------------------------------------------------");

                    string[] lineas = File.ReadAllLines(ruta);

                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(';');

                        Console.WriteLine($"Nombre: {datos[0]}  Tel: {datos[1]}  Correo: {datos[2]}");
                    }
                }

            }
        }
    }

}   
