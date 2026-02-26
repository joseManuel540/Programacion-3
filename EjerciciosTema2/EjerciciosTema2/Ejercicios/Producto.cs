using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema2.Ejercicios
{
    internal class Producto
    {
        public String Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public void Vender(int cantidad)
        {
            if (Stock>=cantidad)
            {
                this.Stock = this.Stock - cantidad;
                double total = this.Precio * cantidad;
                Console.WriteLine("El total es de: "+ total);
            }
            else
            {
                Console.WriteLine("Ya no queda stock del producto");
            }
        }
    }
}
