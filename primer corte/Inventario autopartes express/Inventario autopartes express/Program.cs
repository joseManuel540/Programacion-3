using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario_autopartes_express.Enums;
using Inventario_autopartes_express.Modelos;

namespace Inventario_autopartes_express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE INVENTARIO ===");

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
            Console.WriteLine("1. Crear");
            Console.WriteLine("2. Listar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Modificar");
            Console.WriteLine("0. Salir");
            Console.WriteLine("=====================");
        }

        private static void ProcesarOpcion(int opcion)
        {
            string ruta = "inventario.csv";
            switch (opcion)
            {
                case 1:
                    Crear(ruta);
                    break;
                case 2:
                    Listar(ruta);
                    break;
                case 3:
                    Eliminar2(ruta);
                    break;
                case 4:
                    Modificar(ruta);
                    break;
                case 0:
                    Console.WriteLine("¡Gracias por usar el Sistema de inventario ");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        private static void Crear(string ruta)
        {

            Console.WriteLine("\n=== CREAR REPUESTO ===");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Precio: ");
            double precio = double.Parse(Console.ReadLine());

            Categoria cat = SeleccionarCat();

            var repuesto = new Repuesto(id, nombre, precio, cat);
            File.AppendAllText(ruta, repuesto.ToCSV() + Environment.NewLine);
            Console.WriteLine("repuesto agregado exitosamente!");
        }


        private static Categoria SeleccionarCat()
        {
            Console.WriteLine("\nSeleccione una categoria:");
            var cats = Enum.GetValues(typeof(Categoria));

            for (int i = 0; i < cats.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cats.GetValue(i)}");
            }

            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine()) - 1;

            return (Categoria)cats.GetValue(opcion);
        }

        private static void Listar(string ruta)
        {
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');
                    Console.WriteLine("Id: " + datos[0]);
                    Console.WriteLine("Nombre: " + datos[1]);
                    Console.WriteLine("Precio: " + datos[2]);
                    Console.WriteLine("Categoria: " + datos[3]);

                }
            }
            else
            {
                Console.WriteLine("[WARNING] El archivo CSV aún no existe.");
            }
        }

        private static void Eliminar(string ruta)
        {
            Listar(ruta);
            Console.WriteLine("Escriba el id del que desea eliminar: ");
            int idEliminar = int.Parse(Console.ReadLine());
            File.WriteAllText(ruta, "");

            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                bool encontrado = false;
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');
                    int id = int.Parse(datos[0]);
                    double precio = double.Parse(datos[2]);
                    Categoria cat;

                    if (datos[3].Equals("Motor"))
                    {
                        cat = Categoria.Motor;
                    }
                    else if (datos[3].Equals("Frenos"))
                    {
                        cat = Categoria.Frenos;
                    }
                    else
                    {
                        cat = Categoria.Suspension;
                    }
                    if (id != idEliminar)
                    {
                        var repuesto = new Repuesto(id, datos[1], precio, cat);
                        File.AppendAllText(ruta, repuesto.ToCSV() + Environment.NewLine);
                    }

                }
                //for (int i = 0;  i < lineas.Length; i++)
                //{
                //    string[] datos = linea.Split(';');
                //    Console.WriteLine("Id: " + datos[0]);
                //    Console.WriteLine("Nombre: " + datos[1]);
                //    Console.WriteLine("Precio: " + datos[2]);
                //    Console.WriteLine("Categoria: " + datos[3]);
                //}
            }
            else
            {
                Console.WriteLine("[WARNING] El archivo CSV aún no existe.");
            }

        }


        private static void Eliminar2(string ruta)
        {
            Listar(ruta);
            Console.WriteLine("Escriba el id del que desea eliminar: ");
            int idEliminar = int.Parse(Console.ReadLine());

            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                bool encontrado = false;
                var nuevalineas = new List<string>();
               
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');
                    int id = int.Parse(datos[0]);
                    if (id != idEliminar)
                    {
                        nuevalineas.Add(linea);
                       
                    }

                }
                File.WriteAllLines(ruta, nuevalineas);
                //for (int i = 0;  i < lineas.Length; i++)
                //{
                //    string[] datos = linea.Split(';');
                //    Console.WriteLine("Id: " + datos[0]);
                //    Console.WriteLine("Nombre: " + datos[1]);
                //    Console.WriteLine("Precio: " + datos[2]);
                //    Console.WriteLine("Categoria: " + datos[3]);
                //}
            }
            else
            {
                Console.WriteLine("[WARNING] El archivo CSV aún no existe.");
            }

        }

        private static void Modificar(string ruta)
        {
            Listar(ruta);
            Console.WriteLine("Ingrese la id del repuesto que desea actualizar: ");
            int idAct = int.Parse(Console.ReadLine());

            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');

                    int id = int.Parse(datos[0]);
                    double precio = double.Parse(datos[2]);
                    Categoria cat;

                    if (datos[3].Equals("Motor"))
                    {
                        cat = Categoria.Motor;
                    }
                    else if (datos[3].Equals("Frenos"))
                    {
                        cat = Categoria.Frenos;
                    }
                    else
                    {
                        cat = Categoria.Suspension;
                    }
                    File.WriteAllText(ruta, "");
                    if (id == idAct)
                    {
                        Console.WriteLine("Nueva id: ");
                        int Nid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nuevo nombre: ");
                        string Nnombre = Console.ReadLine();
                        Console.WriteLine("Nuevo precio: ");
                        double Nprecio = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nueva categoria");
                        Categoria Ncat = SeleccionarCat();
                        var repuesto = new Repuesto(Nid, Nnombre, Nprecio, Ncat);
                        File.AppendAllText(ruta, repuesto.ToCSV() + Environment.NewLine);
                    }
                    else
                    {
                        var repuesto = new Repuesto(id, datos[1], precio, cat);
                        File.AppendAllText(ruta, repuesto.ToCSV() + Environment.NewLine);
                    }

                }
                //for (int i = 0;  i < lineas.Length; i++)
                //{
                //    string[] datos = linea.Split(';');
                //    Console.WriteLine("Id: " + datos[0]);
                //    Console.WriteLine("Nombre: " + datos[1]);
                //    Console.WriteLine("Precio: " + datos[2]);
                //    Console.WriteLine("Categoria: " + datos[3]);
                //}
            }
            else
            {
                Console.WriteLine("[WARNING] El archivo CSV aún no existe.");
            }
        }



    }
}
