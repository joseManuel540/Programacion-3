/*EJERCICIO 1: Sistema de Biblioteca Digital
Descripción del Problema
Crear un sistema para gestionar una biblioteca digital que maneja diferentes tipos de materiales: Libros,
Revistas y AudioLibros. Cada material tiene información común pero también características específicas.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerciciosPOO2.BibliotecaDigital.Enums;
using EjerciciosPOO2.BibliotecaDigital.Interfaces;

namespace EjerciciosPOO2.Ejercicio1.Modelos
{
    public abstract class MaterialBiblioteca
    {
        public int Id {  get; set; }
        public String Titulo { get; set; }
        public String Autor {  get; set; }
        public int AñoPublicacion { get; set; }
        public TipoCategoria Categoria { get; set; }

        protected MaterialBiblioteca(int id, String titulo, string autor, int añoPublicacion, TipoCategoria categoria) 
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            Categoria = categoria;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Id = " + Id);
            Console.WriteLine("Titulo = " + Titulo);
            Console.WriteLine("Autor = " + Autor);
            Console.WriteLine("Año publicacion = " + AñoPublicacion);
            Console.WriteLine("Categoria = " + Categoria);
        }

    }
}
