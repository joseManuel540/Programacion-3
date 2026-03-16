using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reto2.Enums;

namespace reto2.Modelos
{
    public class Paquete
    {
        public int Guia {  get; set; }
        public string Destinatario { get; set; }
        public double Peso { get; set; }
        public Tipo Tipo { get; set; }

        public string ToCSV() => $"{Guia};{Destinatario};{Peso};{Tipo}";

        public Paquete(int guia, string destinatario, double peso, Tipo tipo)
        {
            Guia = guia;
            Destinatario = destinatario;
            Peso = peso;
            Tipo = tipo;
        }

        public void MostrarInformacion() 
        {
            Console.WriteLine("Guia: " + Guia);
            Console.WriteLine("Destinatario: " + Destinatario);
            Console.WriteLine("Peso : " + Peso);
            Console.WriteLine("Tipo: " + Tipo);
        }

    }
}
