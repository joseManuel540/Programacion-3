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
        public int Cilindraje { get; set; }
        public bool EsDeportiva { get; set; }

        public Camion(int id, string marca, string modelo, int año, double precioBase,
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
            Console.WriteLine($"Numero de puertas: {NumeroPuertas}");
            Console.WriteLine($"Tiene Aire Acondicionado: {TieneAireAcondicionado}");
            Console.WriteLine("Tipo: Auto");
        }
        public decimal CalcularComisionVendedor()
        {
            throw new NotImplementedException();
        }

        public decimal CalcularPrecioFinal()
        {
            throw new NotImplementedException();
        }

        public void GenerarFacturaVenta()
        {
            throw new NotImplementedException();
        }
    }
}
