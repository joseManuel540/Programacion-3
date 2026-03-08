using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO2Ejercicio2.Enums;
using POO2Ejercicio2.Interfaces;

namespace POO2Ejercicio2.Modelos
{
    public class Camion : Vehiculo, IVendible
    {
        public decimal CapacidadCarga { get; set; }
        public int NumeroEjes { get; set; }

        public Camion(int id, string marca, string modelo, int año, decimal precioBase,
            TipoCombustible combustible, EstadoVehiculo estadoVehiculo, decimal capacidadCarga,
            int numeroEjes)
            : base(id, marca, modelo, año, precioBase, combustible, estadoVehiculo)
        {
            CapacidadCarga = capacidadCarga;
            NumeroEjes = numeroEjes;
        }

        public override void MostrarEspecificaciones()
        {
            base.MostrarEspecificaciones();
            Console.WriteLine($"Capacidad de carga: {CapacidadCarga}");
            Console.WriteLine($"Numero Ejes: {NumeroEjes}");
            Console.WriteLine("Tipo: Camion");
        }
        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.3m;
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (CapacidadCarga * 500);
        }

        public void GenerarFacturaVenta()
        {
            Console.WriteLine("=== FACTURA DE VENTA - CAMION ===");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Capacidad Carga: {CapacidadCarga}");
            Console.WriteLine($"Numero Ejes: {NumeroEjes}");
            Console.WriteLine($"Precio Base: {PrecioBase}");
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal()}");
            Console.WriteLine("===========================================");
        }
    }
}
