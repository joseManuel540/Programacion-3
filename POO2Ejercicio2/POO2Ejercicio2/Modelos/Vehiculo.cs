using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO2Ejercicio2.Enums;

namespace POO2Ejercicio2.Modelos
{
    public abstract class Vehiculo
    {
        public int Id {  get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoCombustible Combustible { get; set; }
        public EstadoVehiculo EstadoVehiculo { get; set; }

        protected Vehiculo(int id, string marca, string modelo, int año, double precioBase, 
            TipoCombustible combustible, EstadoVehiculo estadoVehiculo)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            PrecioBase = precioBase;
            Combustible = combustible;
            EstadoVehiculo = estadoVehiculo;

        }

        public virtual void MostrarEspecificaciones()
        { 
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Año: " + Año);
            Console.WriteLine("Precio Base: " + PrecioBase);
            Console.WriteLine("Combustible: " + Combustible);
            Console.WriteLine("Estado vehiculo: " + EstadoVehiculo);
        }
        

    }
}
