using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerciciosPOO2.BibliotecaDigital.Interfaces;
using EjerciciosPOO2.Ejercicio1.Modelos;

namespace EjerciciosPOO2.BibliotecaDigital.Modelos
{
    internal class Libro : MaterialBiblioteca, IPrestable
    {
        public int NumeroPaginas { get; set; }
        public string ISBN { get; set; }

        public Libro()
    }
}
