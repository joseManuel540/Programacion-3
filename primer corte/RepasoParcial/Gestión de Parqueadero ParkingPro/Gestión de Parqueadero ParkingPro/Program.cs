/*Gestión de Parqueadero "ParkingPro"
Objetivo: Implementar herencia y búsqueda de datos ingresados por el usuario.
¿Qué debes hacer?
1. Clases: Crea una clase abstracta Vehiculo (Placa, Marca) y dos hijas: Carro (nroPuertas) y Moto (Cilindraje).
2. Interfaz: Crea ICobrable con un método CalcularTarifa(int minutos) . Los Carros pagan $100/min y las Motos
$50/min.
3. Menú Principal:
1. Registrar Entrada: Pedir datos por teclado y guardarlos en un arreglo de 5 posiciones.
2. Buscar por Placa: El usuario ingresa una placa y el programa muestra los datos del vehículo y su tarifa
para 60 minutos.
3. Listar Todo: Mostrar todos los vehículos registrados en MAYÚSCULAS.
0. Salir*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestión_de_Parqueadero_ParkingPro.Interfaces;
using Gestión_de_Parqueadero_ParkingPro.Modelos;

namespace Gestión_de_Parqueadero_ParkingPro
{
    internal class Program
    {
        private static List<ICobrable> Vehiculos = new List<ICobrable>();
        static void Main(string[] args)
        {
            Console.WriteLine("=== GESTION DE PARQUEADERO ===");


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
            Console.WriteLine("1. Agregar nuevo carro");
            Console.WriteLine("2. Agregar nueva moto");
            Console.WriteLine("3. Consultar por placa");
            Console.WriteLine("4. Ver todos");
            Console.WriteLine("0. Salir");
            Console.WriteLine("=====================");
        }

        private static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    AgregarCarro();
                    break;
                case 2:
                    AgregarMoto();
                    break;
                case 3:
                    ConsultarPlaca();
                    break;
                case 4:
                    MostrarTodosVehiculos();
                    break;
                case 0:
                    Console.WriteLine("¡Gracias por usar el Sistema de gestion de parqueadero");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        private static void AgregarCarro()
        {
            Console.WriteLine("\n=== AGREGAR NUEVO CARRO ===");
            Console.Write(" Placa: ");
            string placa = Console.ReadLine();

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Numero de puertas: ");
            int nroPuertas = int.Parse(Console.ReadLine());

            var carro = new Carro(placa, marca, nroPuertas);
            Vehiculos.Add(carro);

            Console.WriteLine("Carro agregada exitosamente!");
        }

        private static void AgregarMoto()
        {
            Console.WriteLine("\n=== AGREGAR NUEVA MOTO ===");
            Console.Write(" Placa: ");
            string placa = Console.ReadLine();

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Cilindraje ");
            int cilindraje = int.Parse(Console.ReadLine());

            var moto = new Moto(placa, marca, cilindraje);
            Vehiculos.Add(moto);

            Console.WriteLine("Moto agregada exitosamente!");
        }

        private static void MostrarTodosVehiculos()
        {
            Console.WriteLine("\n=== VEHICULOS DISPONIBLES ===");

            if (Vehiculos.Count == 0)
            {
                Console.WriteLine("No hay vehiculos disponibles.");
                return;
            }

            for (int i = 0; i < Vehiculos.Count; i++)
            {
                Console.WriteLine($"\n--- vehiculo {i + 1} ---");
                if (Vehiculos[i] is Vehiculo material)
                {
                    material.MostrarInformacion();
                }
            }
        }

        private static void ConsultarPlaca()
        {
            Console.WriteLine("Ingrese la placa a buscar: ");
            string buscar = Console.ReadLine();

            if (Vehiculos.Count == 0)
            {
                Console.WriteLine("No hay vehiculos disponibles.");
                return;
            }

            foreach (var item in Vehiculos)
            {
                if (item is Vehiculo v)
                {
                    if (v.Placa.Equals(buscar))
                    {
                        Console.WriteLine("Se encontro el vehiculo: ");
                        v.MostrarInformacion();
                    }
                }
            }
        }


    }
}
