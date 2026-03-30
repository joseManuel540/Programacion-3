using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Restaurante_y_Cocina_Ej3Poo2.Enums;

namespace Sistema_de_Restaurante_y_Cocina_Ej3Poo2.Modelos
{
    public class Plato
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoComida TipoComida { get; set; }
        public NivelDificultad Dificultad { get; set; }
        public EstadoOrden EstadoOrden { get; set; }
       

        protected Plato(int id, string nombre, string descripcion, decimal precioBase,
            TipoComida tipoComida, NivelDificultad dificultad)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioBase = precioBase;
            TipoComida = tipoComida;
            Dificultad = dificultad;

        }

        public virtual void MostrarInformacionNutricional()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Descripcion: " + Descripcion);
            Console.WriteLine("Precio Base: " + PrecioBase);
            Console.WriteLine("Tipo de la comida: " + TipoComida);
            Console.WriteLine("Nivel de dificultad: " + Dificultad);
        }
    }
}
