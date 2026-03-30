using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario_autopartes_express.Enums;
using Inventario_autopartes_express.Interfaces;

namespace Inventario_autopartes_express.Modelos
{
    public class Repuesto
    {
        public int Id { get; set; }
        public  string Nombre { get; set; }
        public double Precio { get; set; }
        public Categoria Categoria { get; set; }
        public string ToCSV() => $"{Id};{Nombre};{Precio};{Categoria}";

        public Repuesto(int id, string nombre, double precio, Categoria categoria)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        }
    }
}
