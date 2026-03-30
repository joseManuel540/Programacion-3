//Control de Inventario (Clase Producto)
//Objetivo: Gestionar la entrada y salida de mercancía.

//Clase: Producto.
//Propiedades: Nombre, Codigo, Precio y CantidadStock.
//Métodos:
//AgregarStock(int cantidad): Aumenta el inventario.
//VenderProducto(int cantidad): Disminuye el inventario y devuelve el total de la venta (Precio * Cantidad).
//MostrarInfo(): Muestra todos los detalles del producto.
//Interacción: El usuario ingresa los datos de un producto y luego decide cuántas unidades "entran" al
//almacén y cuántas se "venden".

using EjerciciosPOO.Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Ejercicios
{
    internal class Producto
    {
        public String Nombre {  get; set; }
        public int Codigo { get; set; }
        public double Precio { get; set; }
        public int CantidadStock { get; set; }

        public void AgregarStock(int cantidad)
        {
            if (cantidad>=1)
            {
                CantidadStock = CantidadStock + cantidad;
            }
            else
            {
                Console.WriteLine("Ingresaste un numero no valido");
            }
        }

        public void VenderProducto(int cantidad) 
        {
            if (cantidad >= 1 && cantidad <= CantidadStock) 
            { 
                CantidadStock = CantidadStock - cantidad;    
                Console.WriteLine("Total venta: " + Precio * cantidad);
            }
            else
            {
                Console.WriteLine("Ingresaste un numero no valido o no hay stock disponible");
            }
        }

        public void MostrarInfo() 
        {
            Console.WriteLine("Informacion del producto: ");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Codigo: " + Codigo);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Stock:  " + CantidadStock);
        }

        public static void Ejecutar()
        {
            Console.WriteLine("EJERCICIO 2:");
            Producto producto = new Producto();

            Console.WriteLine("Ingrese el nombre del producto: ");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo del producto: ");
            producto.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto: ");
            producto.Precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el stock disponible del producto: ");
            producto.CantidadStock = int.Parse(Console.ReadLine());

            int op;
            int cantidad;
            do
            {
                Console.WriteLine("========= MENU ========= ");
                Console.WriteLine("1. AGREGAR STOCK");
                Console.WriteLine("2. VENDER PRODUCTO");
                Console.WriteLine("3. MOSTRAR INFO");
                Console.WriteLine("0. SALIR");
                Console.WriteLine("Ingrese una opcion");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese la cantidad de stock a añadir: ");
                        cantidad = int.Parse(Console.ReadLine());
                        producto.AgregarStock(cantidad);
                        break;

                    case 2:
                        Console.WriteLine("Ingrese la cantidad de productos a comprar: ");
                        cantidad = int.Parse(Console.ReadLine());
                        producto.VenderProducto(cantidad);
                        break;

                    case 3:
                        producto.MostrarInfo();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
            while (op != 0);
        }
    }

    
}
