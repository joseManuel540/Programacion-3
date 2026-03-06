using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerciciosPOO2.BibliotecaDigital.Enums;
using EjerciciosPOO2.BibliotecaDigital.Interfaces;
using EjerciciosPOO2.Ejercicio1.Modelos;

namespace EjerciciosPOO2.BibliotecaDigital.Modelos
{
    internal class Libro : MaterialBiblioteca, IPrestable
    {
        public int NumeroPaginas { get; set; }
        public string ISBN { get; set; }

        public Libro(int id, string titulo, string autor, int año, TipoCategoria categoria, int paginas,
            string isbn) : base(id, titulo, autor, año, categoria)
            {
                NumeroPaginas = paginas;
                ISBN = isbn;
            }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Numero de paginas: "+ NumeroPaginas);
            Console.WriteLine("ISBN: "+ ISBN);
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(7);
        }

        public void GenerarComprobantePrestamo()
        {
            Console.WriteLine($"Libro '{Titulo}' prestado hasta {CalcularFechaDevolucion()}");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 1000;
        }
    }
}
