using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerciciosPOO2.BibliotecaDigital.Enums;
using EjerciciosPOO2.BibliotecaDigital.Interfaces;
using EjerciciosPOO2.BibliotecaDigital.Modelos;

namespace EjerciciosPOO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPrestable> prestamos = new List<IPrestable>();

            Libro libro = new Libro( 1, "C# Profesional", "Juan Perez", 2023, TipoCategoria.Tecnologia,
                450, "ISBN12345"
            );

            Revista revista = new Revista(2, "National Geographic", "Varios", 2024, TipoCategoria.Ciencia,
                55, "Mensual"
            );

            AudioLibro audioLibro = new AudioLibro(
                3, "Aprender Programación","Carlos Lopez",2022,TipoCategoria.Tecnologia,
                TimeSpan.FromHours(10), "Maria Rodriguez"
            );

            prestamos.Add(libro);
            prestamos.Add(revista);
            prestamos.Add(audioLibro);

            foreach (var item in prestamos)
            {
                item.GenerarComprobantePrestamo();

                Console.WriteLine("Fecha devolución: " + item.CalcularFechaDevolucion());

                Console.WriteLine("Multa por 2 días de retraso: " + item.CalcularMultaPorRetraso(2));

                Console.WriteLine("----------------------------");
            }
        }
    }
}
