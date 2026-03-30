using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Restaurante_y_Cocina_Ej3Poo2.Enums;
using Sistema_de_Restaurante_y_Cocina_Ej3Poo2.Interfaces;

namespace Sistema_de_Restaurante_y_Cocina_Ej3Poo2.Modelos
{
    public class Entrada : Plato, IPreparable
    {
        public bool EsFria { get; set; }
        public int Porciones { get; set; }

        public Entrada(int id, string nombre, string descripcion, decimal precioBase,
            TipoComida tipoComida, NivelDificultad dificultad, bool esFria, int porciones)
            : base(id, nombre, descripcion, precioBase, tipoComida, dificultad)
        {
            EsFria = esFria;
            Porciones = porciones;
        }

        public override void MostrarInformacionNutricional()
        {
            base.MostrarInformacionNutricional();
            Console.WriteLine($"Es fria?: {EsFria}");
            Console.WriteLine($"Numero de porciones: {Porciones}");
            Console.WriteLine("Tipo: Entrada");

        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            return EsFria ? TimeSpan.FromMinutes(10) : TimeSpan.FromMinutes(20);
        }

        public void GenerarOrdenCocina()
        {
            Console.WriteLine("=== ORDEN DE COCINA - ENTRADA ===");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Descripcion: {Descripcion}");
            Console.WriteLine($"Precio base: {PrecioBase}");
            Console.WriteLine($"porciones: {Porciones}");
            Console.WriteLine($"Precio final: {CalcularCostoTotal()}");
            Console.WriteLine($"Tiempo de espera: {CalcularTiempoPreparacion()}");
            Console.WriteLine("=========================================");
            Console.WriteLine(this.EstadoOrden = EstadoOrden.Preparando);
        }

        public decimal CalcularCostoTotal()
        {
            return PrecioBase * Porciones;
        }
    }
}
