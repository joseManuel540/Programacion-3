/*EJERCICIO 2: Sistema de Concesionario de Vehículos
📖 Descripción del Problema
Desarrollar un sistema para un concesionario que vende Autos, Motocicletas y Camiones. Cada 
vehículo tiene características comunes pero precios y comisiones diferentes.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO2Ejercicio2.Enums;
using POO2Ejercicio2.Interfaces;
using POO2Ejercicio2.Modelos;

namespace POO2Ejercicio2
{
    internal class Program
    {
        private static List<IVendible> Vendidos = new List<IVendible>();
        private static int siguienteId = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("============== SISTEMA DE CONCESIONARIO DE VEHICULOS ==============");
            Ejemplos();
            
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

            } while (opcion != 6);

        }

        private static void MostrarMenu()
        {
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Agregar auto");
            Console.WriteLine("2. Agregar motocicleta");
            Console.WriteLine("3. Agregar camoin");
            Console.WriteLine("4. Mostrar todos los vendibles");
            Console.WriteLine("5. Generar factura");
            Console.WriteLine("6. Salir");
            Console.WriteLine("=====================");
        }

        private static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    AgregarAuto();
                    break;
                case 2:
                    AgregarMotocicleta();
                    break;
                case 3:
                    AgregarCamion();
                    break;
                case 4:
                    MostrarTodosVendibles();
                    break;
                case 5:
                    GenerarFactura();
                    break;
                case 6:
                    Console.WriteLine("¡Gracias por usar el sistema de concesionario de vehiculos");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        private static void AgregarAuto()
        {
            Console.WriteLine("\n=== AGREGAR AUTO ===");
            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Año: ");
            int año = int.Parse(Console.ReadLine());

            Console.WriteLine("Precio base: ");
            decimal precioBase = decimal.Parse(Console.ReadLine());

            Console.Write("Número de puertas: ");
            int numeroPuertas = int.Parse(Console.ReadLine());

            Console.Write("Tiene aire acondicionado? (true/false): ");
            bool aireAcondicionado = bool.Parse(Console.ReadLine().ToLower());

            TipoCombustible combustible = SeleccionarCombustible();
            EstadoVehiculo estado = SeleccionarEstado();

            Auto auto = new Auto(siguienteId++, marca, modelo, año, precioBase, combustible,
                estado, numeroPuertas, aireAcondicionado);
            Vendidos.Add(auto);

            Console.WriteLine("auto agregado exitosamente!");
        }

        private static void AgregarMotocicleta()
        {
            Console.WriteLine("\n=== AGREGAR MOTOCICLETA ===");
            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Año: ");
            int año = int.Parse(Console.ReadLine());

            Console.WriteLine("Precio base: ");
            decimal precioBase = decimal.Parse(Console.ReadLine());

            Console.Write("Cilindraje ");
            int cilindraje = int.Parse(Console.ReadLine());

            Console.Write("Es deportiva? (true/false): ");
            bool deportiva = bool.Parse(Console.ReadLine().ToLower());

            TipoCombustible combustible = SeleccionarCombustible();
            EstadoVehiculo estado = SeleccionarEstado();

            Motocicleta moto = new Motocicleta(siguienteId++, marca, modelo, año, precioBase, 
                combustible, estado, cilindraje, deportiva);
            Vendidos.Add(moto);

            Console.WriteLine("moto agregada exitosamente!");
        }

        private static void AgregarCamion()
        {
            Console.WriteLine("\n=== AGREGAR CAMION ===");
            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Año: ");
            int año = int.Parse(Console.ReadLine());

            Console.WriteLine("Precio base: ");
            decimal precioBase = decimal.Parse(Console.ReadLine());

            Console.Write("Capacidad Carga: ");
            decimal capacidadCarga = decimal.Parse(Console.ReadLine());

            Console.Write("Numero de ejes: ");
            int numeroEjes = int.Parse(Console.ReadLine());

            TipoCombustible combustible = SeleccionarCombustible();
            EstadoVehiculo estado = SeleccionarEstado();

            Camion camion = new Camion(siguienteId++, marca, modelo, año, precioBase, combustible,
                estado, capacidadCarga, numeroEjes);
            Vendidos.Add(camion);

            Console.WriteLine("camion agregado exitosamente!");
        }

        private static TipoCombustible SeleccionarCombustible()
        {
            Console.WriteLine("\nSeleccione un combustible:");
            var combustible = Enum.GetValues(typeof(TipoCombustible));

            for (int i = 0; i < combustible.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {combustible.GetValue(i)}");
            }

            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine()) - 1;

            return (TipoCombustible)combustible.GetValue(opcion);
        }

        private static EstadoVehiculo SeleccionarEstado()
        {
            Console.WriteLine("\nSeleccione un estado:");
            var estado = Enum.GetValues(typeof(EstadoVehiculo));

            for (int i = 0; i < estado.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {estado.GetValue(i)}");
            }

            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine()) - 1;

            return (EstadoVehiculo)estado.GetValue(opcion);
        }

        private static void MostrarTodosVendibles()
        {
            Console.WriteLine("\n=== VEHICULOS DISPONIBLES ===");

            if (Vendidos.Count == 0)
            {
                Console.WriteLine("No hay vendibles disponibles.");
                return;
            }

            for (int i = 0; i < Vendidos.Count; i++)
            {
                Console.WriteLine($"\n--- VEHICULO {i + 1} ---");
                if (Vendidos[i] is Vehiculo material)
                {
                    material.MostrarEspecificaciones();
                }
            }
        }

        private static void GenerarFactura()
        {
            Console.WriteLine("\n=========== FACTURA ===========");

            if (Vendidos.Count == 0)
            {
                Console.WriteLine("No hay vendibles disponibles.");
                return;
            }

            MostrarTodosVendibles();

            Console.Write("\nSeleccione el número del vehiculo a comprar ");
            if (int.TryParse(Console.ReadLine(), out int seleccion) &&
                seleccion >= 1 && seleccion <= Vendidos.Count)
            {
                var vendibleSeleccionado = Vendidos[seleccion - 1];

                Console.WriteLine("\n");
                vendibleSeleccionado.GenerarFacturaVenta();

                Console.WriteLine("La comision del vendedor del vehiculo es de: ");
                Console.WriteLine(vendibleSeleccionado.CalcularComisionVendedor());
                
            }
          
        }
        private static void Ejemplos()
        {
            Auto auto1 = new Auto(siguienteId++, "Ford", "Bronco", 2024, 2000, TipoCombustible.Gasolina,
                EstadoVehiculo.Nuevo, 4, true);
            Camion camion1 = new Camion(siguienteId++, "MAN", "Delivery", 2025, 4000, TipoCombustible.Diesel,
                EstadoVehiculo.Seminuevo, 24.4m, 6);
            Motocicleta motocicleta1 = new Motocicleta(siguienteId++, "Yamaha", "SuperSport", 2020, 800,
                TipoCombustible.Gasolina, EstadoVehiculo.Usado, 4, true);

            Vendidos.Add(auto1);
            Vendidos.Add(camion1);
            Vendidos.Add(motocicleta1);
        }



    }
}
