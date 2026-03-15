using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creador_de_Estructura_de_Proyectos_archivoEj3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del proyecto");
            string nombre = Console.ReadLine();
            if (!Directory.Exists(nombre))
            {
                Directory.CreateDirectory(nombre);
                Console.WriteLine($"[INFO] Carpeta '{nombre}' creada.");
            }

            string documentos = Path.Combine(nombre, "documentos");
            string imagenes = Path.Combine(nombre, "imagenes");
            string codigo = Path.Combine(nombre, "codigo");
            Directory.CreateDirectory(documentos);
            Directory.CreateDirectory(imagenes);
            Directory.CreateDirectory(codigo);

            Console.WriteLine("Ingrese una descripcion del proyecto");
            string descripcion = Console.ReadLine();

            string rutaReadMe = Path.Combine(documentos, "readme.txt");

            File.WriteAllText(rutaReadMe, descripcion);

            Console.WriteLine($"proyecto creado en: {Path.GetFullPath(nombre)}");

        }

    }
}
