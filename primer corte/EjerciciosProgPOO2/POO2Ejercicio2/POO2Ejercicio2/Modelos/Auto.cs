using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO2Ejercicio2.Enums;
using POO2Ejercicio2.Interfaces;

namespace POO2Ejercicio2.Modelos
{
    public class Auto : Vehiculo, IVendible
    {
        public int NumeroPuertas { get; set; }
        public bool TieneAireAcondicionado { get; set; }

        public Auto(int id, string marca, string modelo, int año, decimal precioBase,
            TipoCombustible combustible, EstadoVehiculo estadoVehiculo, int numeroPuertas,
            bool tieneAireAcondicionado)
            : base(id, marca, modelo, año, precioBase, combustible, estadoVehiculo)
        {
            NumeroPuertas = numeroPuertas;
            TieneAireAcondicionado = tieneAireAcondicionado;
        }

        public override void MostrarEspecificaciones()
        {
            base.MostrarEspecificaciones();
            Console.WriteLine($"Numero de puertas: {NumeroPuertas}");
            Console.WriteLine($"Tiene Aire Acondicionado: {TieneAireAcondicionado}");
            Console.WriteLine("Tipo: Auto");
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (TieneAireAcondicionado ? 2000 : 0);
;        }

        public void GenerarFacturaVenta()
        {
            Console.WriteLine("=== FACTURA DE VENTA - AUTO ===");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Numero de puertas: {NumeroPuertas}");
            Console.WriteLine($"Aire Acondicionado: {TieneAireAcondicionado}");
            Console.WriteLine($"Precio Base: {PrecioBase}");
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal()}");
            Console.WriteLine("===========================================");
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.2m;
        }
    }
}
