using System;
using EjercicioClasePracticaPOO.Interfaces;

namespace EjercicioClasePracticaPOO.Modelos
{
    internal class Podcast : IReproductor
    {
        public string Titulo {  get; set; }
        public string Creador { get; set; }
        public double Episodio { get; set; }

        public void Play()
        {
            Console.WriteLine($"Reproduciendo el podcast: {Titulo} de {Creador} episodio {Episodio}");
        }

        public void Stop()
        {
            Console.WriteLine($"deteniendo el podcast: {Titulo} de {Creador} episodio {Episodio}");
        }
    }
}
