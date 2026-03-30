using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialEjercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            Console.WriteLine("Ingrese el monto del prestamo: ");
            double prestamo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tasa de intereses mensual: (10,20,30..)");
            double intereses = double.Parse(Console.ReadLine());
            double interesespor = intereses / 100;
            Console.WriteLine("Ingrese el plazo en meses para pagar: ");
            int meses = int.Parse(Console.ReadLine());

            double cuotamensual = prestamo / meses;

            Console.WriteLine($"Monto: ${prestamo} | Intereses: {intereses}% | Meses: {meses}");
            Console.WriteLine("------------------- TABLA DE PAGOS -------------------");

            double pagomeses = prestamo / meses;
            for (int i = 0; i < meses; i++)
            {
                Console.WriteLine($" Mes: {i + 1} {fecha.ToShortDateString()}| Cap: ${pagomeses} | Intereses: ${interesespor*prestamo}");
                fecha = fecha.AddMonths(1);
            }
            double totalinteres = (interesespor * prestamo) * meses;
            Console.WriteLine($"Total pagado: {(prestamo+totalinteres)} | Intereses: {totalinteres}");

        }
    }
}
