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
    internal class AudioLibro : MaterialBiblioteca, IPrestable
    {
        public TimeSpan Duracion { get; set; }
        public string Narrador { get; set; }

        public AudioLibro(int id, string titulo, string autor, int año,
                          TipoCategoria categoria, TimeSpan duracion, string narrador)
            : base(id, titulo, autor, año, categoria)
        {
            Duracion = duracion;
            Narrador = narrador;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Duración: {Duracion}");
            Console.WriteLine($"Narrador: {Narrador}");
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(4);
        }

        public void GenerarComprobantePrestamo()
        {
            Console.WriteLine($"Audiolibro '{Titulo}' prestado hasta {CalcularFechaDevolucion()}");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 800;
        }
    }
}
