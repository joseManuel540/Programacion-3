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
    internal class Revista : MaterialBiblioteca, IPrestable
    {
        public int NumeroEdicion { get; set; }
        public string Periodicidad { get; set; }

        public Revista(int id, string titulo, string autor, int año, TipoCategoria categoria, 
            int edicion, string periodicidad) : base(id, titulo, autor, año, categoria)
        {
            NumeroEdicion = edicion;
            Periodicidad = periodicidad;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Edicion: "+ NumeroEdicion);
            Console.WriteLine("Periodicidad: " + Periodicidad);
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(5);
        }

        public void GenerarComprobantePrestamo()
        {
            Console.WriteLine("================== COMRPOBANTE DE PRESTA ==================");
            Console.WriteLine($"Revista '{Titulo}' prestado hasta {CalcularFechaDevolucion()}.");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 500;
        }
    }
}
