///App de Streaming de Música: Crea una interfaz IReproductor con métodos Play() y
///Stop(). Implementa esta interfaz en clases como Cancion y Podcast. El usuario
///debe poder "darle play" a cualquiera de los dos.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema2.Ejercicios
{
    internal interface IReproductor
    {
        void Play();
        void Stop();
    }
}
