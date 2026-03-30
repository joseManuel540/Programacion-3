using System;
using EjercicioClasePracticaPOO.Interfaces;

namespace EjercicioClasePracticaPOO.Modelos
{
    // ":" es para heredar clases e interfaces
    public class Cancion : IReproductor
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }

        public void Play()
        {
            Console.WriteLine($"Reproduciendo la cancion: {Titulo} de {Artista} del album {Album}");
        }

        public void Stop()
        {
            Console.WriteLine($"Deteniendo la cancion: {Titulo} de {Artista} del album {Album}");
        }
    }
}
