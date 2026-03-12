using System;
using Sistema_de_Restaurante_y_Cocina_Ej3Poo2.Enums;
using Sistema_de_Restaurante_y_Cocina_Ej3Poo2.Interfaces;

namespace Sistema_de_Restaurante_y_Cocina_Ej3Poo2.Modelos
{
    public class PlatoPrincipal : Plato, IPreparable
    {
        public string ProteinaPrincipal { get; set; }
        public bool IncluyeGuarnicion { get; set; }

        public PlatoPrincipal(int id, string nombre, string descripcion, decimal precioBase,
            TipoComida tipoComida, NivelDificultad dificultad, string proteinaPrincipal, bool incluyeGuarnicion)
            : base(id, nombre, descripcion, precioBase, tipoComida, dificultad)
        {
            ProteinaPrincipal = proteinaPrincipal;
            IncluyeGuarnicion = incluyeGuarnicion;
        }

        public override void MostrarInformacionNutricional()
        {
            base.MostrarInformacionNutricional();
            Console.WriteLine($"Proteina Principal: {ProteinaPrincipal}");
            Console.WriteLine($"Guarnicion: {IncluyeGuarnicion}");
            Console.WriteLine("Tipo: Plato Principal");

        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            return TimeSpan.FromMinutes(30 + ((int)Dificultad * 15));
        }

        public void GenerarOrdenCocina()
        {
            Console.WriteLine("=== ORDEN DE COCINA - PLATO PRINCIPAL ===");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Descripcion: {Descripcion}");
            Console.WriteLine($"Precio base: {PrecioBase}");
            Console.WriteLine($"Guarnicion: {IncluyeGuarnicion}");
            Console.WriteLine($"Precio final: {CalcularCostoTotal()}");
            Console.WriteLine($"Tiempo de espera: {CalcularTiempoPreparacion()}");
            Console.WriteLine("=========================================");
            Console.WriteLine(this.EstadoOrden = EstadoOrden.Preparando);
        }

        public decimal CalcularCostoTotal()
        {
            return PrecioBase + (IncluyeGuarnicion ? PrecioBase * 0.2m : 0);
        }

    }
}
