using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO2Ejercicio2.Enums;
using POO2Ejercicio2.Interfaces;

namespace POO2Ejercicio2.Modelos
{
    public class Motocicleta : Vehiculo, IVendible
    {
        public int Cilindraje { get; set; }
        public bool EsDeportiva { get; set; }

        public Motocicleta(int id, string marca, string modelo, int año, decimal precioBase,
            TipoCombustible combustible, EstadoVehiculo estadoVehiculo, int cilindraje,
            bool esDeportiva)
            : base(id, marca, modelo, año, precioBase, combustible, estadoVehiculo)
        {
            Cilindraje = cilindraje;
            EsDeportiva = esDeportiva;
        }

        public override void MostrarEspecificaciones()
        {
            base.MostrarEspecificaciones();
            Console.WriteLine($"Cilindraje: {Cilindraje}");
            Console.WriteLine($"Es deportiva: {EsDeportiva}");
            Console.WriteLine("Tipo: motocicleta");
        }
        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.1m;
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (EsDeportiva ? Cilindraje * 500: 0);
        }

        public void GenerarFacturaVenta()
        {
            Console.WriteLine("=== FACTURA DE VENTA - CAMION ===");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Cilindraje: {Cilindraje}");
            Console.WriteLine($"Es deportiva: {EsDeportiva}");
            Console.WriteLine($"Precio Base: {PrecioBase}");
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal()}");
            Console.WriteLine("===========================================");
        }
    }
}
