/*Crear un sistema para un restaurante que maneja diferentes tipos de platos: Entradas, 
 * PlatosPrincipales y Postres. Cada tipo de plato tiene tiempos de preparación y costos 
 * diferentes.
Estructura de Carpetas Requerida
SistemaRestaurante\
├── Enums\
│   ├── TipoComida.cs           ← Vegetariana, Vegana, Carnivora, Mariscos
│   ├── NivelDificultad.cs      ← Facil, Intermedio, Avanzado
│   └── EstadoOrden.cs          ← Pendiente, Preparando, Listo, Entregado
├── Interfaces\
│   └── IPreparable.cs          ← ContratoPreparacion
├── Modelos\
│   ├── Plato.cs                ← Clase abstracta base
│   ├── Entrada.cs              ← Hereda de Plato
│   ├── PlatoPrincipal.cs       ← Hereda de Plato
│   └── Postre.cs               ← Hereda de Plato
└── Program.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Sistema_de_Restaurante_y_Cocina_Ej3Poo2.Enums;
using Sistema_de_Restaurante_y_Cocina_Ej3Poo2.Interfaces;
using Sistema_de_Restaurante_y_Cocina_Ej3Poo2.Modelos;

namespace Sistema_de_Restaurante_y_Cocina_Ej3Poo2
{
    internal class Program
    {
        private static List<IPreparable> Platos = new List<IPreparable>();
        private static int siguienteId = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE RESTAURANTE Y COCINA ===");

            // Agregar algunos materiales de ejemplo
            InicializarMaterialesEjemplo();

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
            Console.WriteLine("1. Agregar nueva entrada");
            Console.WriteLine("2. Agregar nuevo plato principal");
            Console.WriteLine("3. Agregar nuevo postre");
            Console.WriteLine("4. Mostrar todos los platos");
            Console.WriteLine("5. Pedir plato");
            Console.WriteLine("6. Salir");
            Console.WriteLine("=====================");
        }

        private static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    AgregarEntrada();
                    break;
                case 2:
                    AgregarPlatoPrincipal();
                    break;
                case 3:
                    AgregarPostre();
                    break;
                case 4:
                    MostrarTodosMateriales();
                    break;
                case 5:
                    ProcesarOrden();
                    break;
                case 6:
                    Console.WriteLine("¡Gracias por usar el Sistema de restaurante y cocina!");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        private static void AgregarEntrada()
        {
            Console.WriteLine("\n=== AGREGAR NUEVA ENTRADA ===");
            Console.Write(" Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Descripcion: ");
            string descripcion = Console.ReadLine();

            Console.Write("Precio base: ");
            decimal precioBase = decimal.Parse(Console.ReadLine());

            Console.Write("Es fria? (true/false)");
            bool esFria = bool.Parse(Console.ReadLine().ToLower());

            Console.Write("Porciones: ");
            int porciones = int.Parse(Console.ReadLine());

            TipoComida comida = SeleccionarComida();

            NivelDificultad dificultad = SeleccionarDificultad();

            var entrada = new Entrada(siguienteId++, nombre, descripcion, precioBase,
             comida, dificultad, esFria, porciones);
            Platos.Add(entrada);

            Console.WriteLine("Entrada agregada exitosamente!");
        }

        private static void AgregarPlatoPrincipal()
        {
            Console.WriteLine("\n=== AGREGAR NUEVO PLATO PRINCIPAL ===");
            Console.Write(" Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Descripcion: ");
            string descripcion = Console.ReadLine();

            Console.Write("Precio base: ");
            decimal precioBase = decimal.Parse(Console.ReadLine());

            Console.Write("Viene con guarnicion? (true/false)");
            bool guarnicion = bool.Parse(Console.ReadLine().ToLower());

            Console.Write("Proteina principal: ");
            string proteina = Console.ReadLine();

            TipoComida comida = SeleccionarComida();

            NivelDificultad dificultad = SeleccionarDificultad();

            var platoPrincipal = new PlatoPrincipal(siguienteId++, nombre, descripcion, precioBase,
             comida, dificultad, proteina, guarnicion);
            Platos.Add(platoPrincipal);

            Console.WriteLine("Plato principal agregada exitosamente!");
        }

        private static void AgregarPostre()
        {
            Console.WriteLine("\n=== AGREGAR NUEVO POSTRE ===");
            Console.Write(" Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Descripcion: ");
            string descripcion = Console.ReadLine();

            Console.Write("Precio base: ");
            decimal precioBase = decimal.Parse(Console.ReadLine());

            Console.Write("Contiene lactosa? (true/false)");
            bool lactosa = bool.Parse(Console.ReadLine().ToLower());

            Console.Write("Calorias por porcion: ");
            int porcion = int.Parse(Console.ReadLine());

            TipoComida comida = SeleccionarComida();

            NivelDificultad dificultad = SeleccionarDificultad();

            var postre = new Postre(siguienteId++, nombre, descripcion, precioBase,
             comida, dificultad, porcion, lactosa);
            Platos.Add(postre);

            Console.WriteLine("postre agregada exitosamente!");
        }

        private static TipoComida SeleccionarComida()
        {
            Console.WriteLine("\nSeleccione un tipo de comida:");
            var comidas = Enum.GetValues(typeof(TipoComida));

            for (int i = 0; i < comidas.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {comidas.GetValue(i)}");
            }

            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine()) - 1;

            return (TipoComida)comidas.GetValue(opcion);
        }

        private static NivelDificultad SeleccionarDificultad()
        {
            Console.WriteLine("\nSeleccione un tipo de dificultdad:");
            var dificultad = Enum.GetValues(typeof(NivelDificultad));

            for (int i = 0; i < dificultad.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {dificultad.GetValue(i)}");
            }

            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine()) - 1;

            return (NivelDificultad)dificultad.GetValue(opcion);
        }

        private static void MostrarTodosMateriales()
        {
            Console.WriteLine("\n=== MATERIALES DISPONIBLES ===");

            if (   Platos.Count == 0)
            {
                Console.WriteLine("No hay materiales disponibles.");
                return;
            }

            for (int i = 0; i < Platos.Count; i++)
            {
                Console.WriteLine($"\n--- Material {i + 1} ---");
                if (Platos[i] is Plato material)
                {
                    material.MostrarInformacionNutricional();
                }
            }
        }

        private static void ProcesarOrden()
        {
            Console.WriteLine("\n=== PROCESAR PRÉSTAMO ===");

            if (Platos.Count == 0)
            {
                Console.WriteLine("No hay materiales disponibles para préstamo.");
                return;
            }

            MostrarTodosMateriales();

            Console.Write("\nSeleccione el número del plato a pedir ");
            if (int.TryParse(Console.ReadLine(), out int seleccion) &&
                seleccion >= 1 && seleccion <= Platos.Count)
            {
                var platoSeleccionado = Platos[seleccion - 1];

                Console.WriteLine("\n");
                platoSeleccionado.GenerarOrdenCocina();

                // Simular cálculo de multa por retraso
                //Console.Write("\n¿Desea simular días de retraso? (0 para no): ");
                //if (int.TryParse(Console.ReadLine(), out int diasRetraso) && diasRetraso > 0)
                //{
                //    decimal multa = materialSeleccionado.CalcularMultaPorRetraso(diasRetraso);
                //    Console.WriteLine($"Multa por {diasRetraso} días de retraso: ${multa:F2}");
                //}
            }
            //else
            //{
            //    Console.WriteLine("Selección inválida.");
            //}
        }

        private static void InicializarMaterialesEjemplo()
        {
            // Agregar algunos materiales de ejemplo
            var entrada1 = new Entrada(siguienteId++, "Empanadas", "Empanadas de carne con arroz y de pollo",
                1, TipoComida.Carnivora, NivelDificultad.Facil, false, 5);

            var platoPrincipal1 = new PlatoPrincipal(siguienteId++, "Lasaña", "Lasaña con carne y queso",
                10, TipoComida.Carnivora, NivelDificultad.Intermedio, "Carne", false);

            var postre1 = new Postre(siguienteId++, "Tiramisú", "Postre italiano con café y mascarpone",
                5, TipoComida.Vegetariana, NivelDificultad.Intermedio, 450, true);

            Platos.Add(entrada1);
            Platos.Add(platoPrincipal1);
            Platos.Add(postre1);
        }


    }
}
