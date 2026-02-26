using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerciciosTema2.Ejercicios;

namespace EjerciciosTema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            ///EJERCICIO 1
            Console.WriteLine("EJERCICIO 1:");

            List<Mascota> mascotas = new List<Mascota>();

            Loro loro1 = new Loro();
            loro1.Nombre = "Pepe";

            Gato gato1 = new Gato();
            gato1.Nombre = "Max";

            mascotas.Add(loro1);
            mascotas.Add(gato1);

            Console.WriteLine("Escoge una mascota para ver su truco");
            Console.WriteLine("1. Loro");
            Console.WriteLine("2. Gato");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion >= 1 && opcion<=mascotas.Count)
            {
                mascotas[opcion - 1].HacerTruco();
            }


            ///EJERCICIO 2

            Console.WriteLine("EJERCICIO 2:");
            Producto producto1 = new Producto();

            producto1.Nombre = "pc";
            producto1.Precio = 200;
            producto1.Stock = 5;

            Console.WriteLine("cuantas unidades quiere comprar?");
            int cantidad = int.Parse(Console.ReadLine());

            producto1.Vender(cantidad);

            ///EJERCICIO 4
            Console.WriteLine("EJERCICIO 4:");
            Libro libro1 = new Libro();
            libro1.Prestar();
            libro1.getDisponible();

            ///EJERCICIO 5
            Console.WriteLine("EJERCICIO 5:");
            VehiculoElectrico carro = new VehiculoElectrico();

            carro.NivelBateria = 50;

            Console.WriteLine("¿Cuántos kilómetros deseas viajar?");
            int km = int.Parse(Console.ReadLine());

            carro.Viajar(km);
        }
    }
}
