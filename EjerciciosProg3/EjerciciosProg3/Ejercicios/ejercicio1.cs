using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProg3.Ejercicios
{
    internal class ejercicio1
    {
        public static void Ejecutar()
        {
            //Perfil de Usuario Gamer: Crea un programa que pida al usuario su Nickname,
            //nivel de experiencia (1-100) y si tiene suscripción Premium (booleano). Al
            //final, muestra un mensaje personalizado que le dé la bienvenida a su nivel
            //correspondiente.
            Console.WriteLine("Ingrese su nombre: ");
            String nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su nivel de experiencia (1-100)");
            int experiencia = int.Parse(Console.ReadLine());

            Console.WriteLine("Tienes una suscripcion premium? (true/false)");
            bool suscripcion = bool.Parse(Console.ReadLine());

            Console.WriteLine("BIENVENIDO USUARIO");
            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su nivel de experiencia es: " + experiencia);
            Console.WriteLine("Suscripcion: " + suscripcion);
        }
    }
}
