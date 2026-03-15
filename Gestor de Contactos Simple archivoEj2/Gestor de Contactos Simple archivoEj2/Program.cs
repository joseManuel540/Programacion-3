/*Gestor de Contactos Simple (Formato CSV)
Objetivo: Aplicar el concepto de datos estructurados para guardar una pequeña agenda de 
contactos.
Instrucciones:
Crea una clase Contacto con las propiedades: Nombre, Telefono y Correo.
Solicita estos tres datos al usuario por teclado.
Implementa un método ToCSV() en la clase que devuelva los datos separados por punto y coma (;).
Guarda el contacto en un archivo contactos.csv.
Validación: Antes de guardar, usa String.Trim() y String.ToLower() para normalizar el correo 
electrónico.
Al finalizar, pregunta al usuario si desea "Listar contactos". Si dice que sí, lee el archivo,
haz un Split(';') y muestra los datos en una tabla limpia en la consola.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestor_de_Contactos_Simple_archivoEj2.Clases;

namespace Gestor_de_Contactos_Simple_archivoEj2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contacto.Ejecutar();
        }
    }
}
