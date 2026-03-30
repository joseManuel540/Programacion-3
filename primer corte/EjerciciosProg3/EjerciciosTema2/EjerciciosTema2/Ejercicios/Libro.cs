///Sistema de Biblioteca: Crea una clase Libro que tenga un estado (Disponible o 
///Prestado). Crea un método Prestar() que cambie el estado solo si el libro está
///disponible.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema2.Ejercicios
{
    internal class Libro
    {
        private Boolean disponible = true;

        public void getDisponible()
        {
            Console.WriteLine(disponible);
        }

        public void Prestar()
        {
            if (disponible)
            { 
                this.disponible = false;
            }
            else
            {
                Console.WriteLine("El libro ya esta prestado");
            }
        }
    }
}
