/*Sistema de Envíos "GlobalShip" (Persistencia CSV)
Objetivo: Guardar y leer información estructurada en archivos de texto.
¿Qué debes hacer?
1. Modelo: Crea una clase Paquete con: Guia (int), Destinatario (string), Peso (double) y Tipo
(Enum:
Nacional, Internacional).
2. Menú Principal:
1. Crear Envío: Pedir datos al usuario y anexarlos a un archivo llamado envios.csv usando el 
formato:
guia;destinatario;peso;tipo .
2. Reporte de Carga: Leer el archivo y sumar el peso total de todos los paquetes registrados.
3. Buscar por Guía: Leer el archivo y mostrar solo la información del paquete que coincida con 
la guía
ingresada.
0. Salir*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reto2.Enums;
using reto2.Modelos;

namespace reto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE ENVIOS GLOBALSHIP ===");

            int opcion;
            do
            {
                MostrarMenu();
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    ProcesarOpcion(opcion);
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcion != 0);
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Nuevo Envio");
            Console.WriteLine("2. Ver Peso Total");
            Console.WriteLine("3. Buscar por guia");
            Console.WriteLine("0. Salir");
            Console.WriteLine("=====================");
        }

        private static void ProcesarOpcion(int opcion)
        {
            string ruta = "paquetes.csv";
            switch (opcion)
            {
                case 1:
                    AgregarEnvio(ruta);
                    break;
                case 2:
                    MostrarPesoTotal(ruta);
                    break;
                case 3:
                    BuscarPorGuia(ruta);
                    break;
                case 0:
                    Console.WriteLine("¡Gracias por usar el Sistema de Envios ");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        private static void AgregarEnvio(string ruta)
        {
            
            Console.WriteLine("\n=== AGREGAR ENVIO ===");
            Console.Write("Guia: ");
            int guia = int.Parse(Console.ReadLine());

            Console.Write("Destinatario: ");
            string destinatario = Console.ReadLine();

            Console.Write("Peso: ");
            double peso = double.Parse(Console.ReadLine());

            Tipo tipo = SeleccionarTipo();

            var paquete = new Paquete(guia, destinatario, peso, tipo);
            File.AppendAllText(ruta, paquete.ToCSV() + Environment.NewLine);
            Console.WriteLine("paquete agregado exitosamente!");
        }

     
        private static Tipo SeleccionarTipo()
        {
            Console.WriteLine("\nSeleccione un tipo:");
            var tipos = Enum.GetValues(typeof(Tipo));

            for (int i = 0; i < tipos.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {tipos.GetValue(i)}");
            }

            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine()) - 1;

            return (Tipo)tipos.GetValue(opcion);
        }

        private static void MostrarPesoTotal(string ruta)
        {
            double pesoTotal = 0;
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');
                    double pesos = double.Parse(datos[2]);
                    pesoTotal += pesos;
                }
                Console.WriteLine("PESO TOTAL: " + pesoTotal);
            }
            else
            {
                Console.WriteLine("[WARNING] El archivo CSV aún no existe.");
            }
        }

        private static void BuscarPorGuia(string ruta) 
        {
            Console.WriteLine("Ingrese la guia");
            int n = int.Parse(Console.ReadLine());
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');
                    int guia = int.Parse(datos[0]);
                    bool encontrado = false;

                    if (guia == n)
                    {
                        encontrado = true;
                        Console.WriteLine("Envio encontrado");
                        Console.WriteLine("Guia: " + datos[0]);
                        Console.WriteLine("Destinatario: " + datos[1]);
                        Console.WriteLine("Peso: " + datos[2]);
                        Console.WriteLine("Tipo: " + datos[3]);
                    }
                    if (!true)
                    {
                        Console.WriteLine("No se encontro");
                    }
                }
            }
            else
            {
                Console.WriteLine("[WARNING] El archivo CSV aún no existe.");
            }
        }
        
      
    }
    
}
