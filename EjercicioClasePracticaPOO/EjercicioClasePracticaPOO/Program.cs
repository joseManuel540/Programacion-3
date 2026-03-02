///app de streaming de musica crar interfaz IReproductor con metodo play y stop, impletarlos en
///clases como cancion y podcast. el usuario debe poder darle play a cualquiera de los dos.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClasePracticaPOO.Interfaces;
using EjercicioClasePracticaPOO.Modelos;

namespace EjercicioClasePracticaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al reproductor de musica y podacast");
            
            List<IReproductor> PlayList = new List<IReproductor>();

            int op;
   
            do
            {
                Console.WriteLine("========= MENU ========= ");
                Console.WriteLine("1. AGREGAR CANCION");
                Console.WriteLine("2. AGREGAR PODCAST");
                Console.WriteLine("3. REPRODUCIR TODO");
                Console.WriteLine("0. SALIR");
                Console.WriteLine("Ingrese una opcion");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Nombre de la cancion");
                        String nombreCancion = Console.ReadLine();
                        Console.WriteLine("Nombre del artista");
                        String artista = Console.ReadLine();
                        Console.WriteLine("Album");
                        String album = Console.ReadLine();

                        PlayList.Add(new Cancion {Titulo = nombreCancion, Artista = artista, Album = album});
                        break;

                    case 2:
                        Console.WriteLine("Nombre del podcast");
                        String tituloPodcast = Console.ReadLine();
                        Console.WriteLine("Nombre del autor");
                        String creador = Console.ReadLine();
                        Console.WriteLine("Episodio");
                        int episidio = int.Parse(Console.ReadLine());

                        PlayList.Add(new Podcast { Titulo = tituloPodcast, Creador = creador, Episodio = episidio });
                        break;

                    case 3:
                        Console.WriteLine("Reproduciendo todo...");
                        foreach (var item in PlayList)
                        {
                            item.Play();
                        }

                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa. Deteniendo la play list...");
                        foreach (var item in PlayList)
                        {
                            item.Stop();
                        }
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
            while (op != 0);
        }
    }
}
