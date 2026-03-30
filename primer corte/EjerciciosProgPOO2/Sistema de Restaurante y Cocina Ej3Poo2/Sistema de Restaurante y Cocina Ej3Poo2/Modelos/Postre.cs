using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Restaurante_y_Cocina_Ej3Poo2.Enums;
using Sistema_de_Restaurante_y_Cocina_Ej3Poo2.Interfaces;

namespace Sistema_de_Restaurante_y_Cocina_Ej3Poo2.Modelos
{
    public class Postre : Plato, IPreparable
    {
        public int CaloriasPorPorcion { get; set; }
        public bool ContieneLactosa { get; set; }

        public Postre(int id, string nombre, string descripcion, decimal precioBase,
            TipoComida tipoComida, NivelDificultad dificultad, int caloriasPorPorcion, bool contieneLactosa)
            : base(id, nombre, descripcion, precioBase, tipoComida, dificultad)
        {
            CaloriasPorPorcion = caloriasPorPorcion;
            ContieneLactosa = contieneLactosa;
        }

        public override void MostrarInformacionNutricional()
        {
            base.MostrarInformacionNutricional();
            Console.WriteLine($"Calorias por porcion: {CaloriasPorPorcion}");
            Console.WriteLine($"Lactosa? : {ContieneLactosa}");
            Console.WriteLine("Tipo: Postre");

        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            return TimeSpan.FromMinutes(25 + (ContieneLactosa ? 5 : 0));
        }

        public void GenerarOrdenCocina()
        {
            Console.WriteLine("=== ORDEN DE COCINA - POSTRE ===");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Descripcion: {Descripcion}");
            Console.WriteLine($"Precio base: {PrecioBase}");
            Console.WriteLine($"Calorias por porcion: {CaloriasPorPorcion}");
            Console.WriteLine($"Lactosa: {ContieneLactosa}");
            Console.WriteLine($"Precio final: {CalcularCostoTotal()}");
            Console.WriteLine($"Tiempo de espera: {CalcularTiempoPreparacion()}");
            Console.WriteLine("=========================================");
            Console.WriteLine(this.EstadoOrden = EstadoOrden.Preparando);
        }

        public decimal CalcularCostoTotal()
        {
            return PrecioBase;
        }
    }
}
