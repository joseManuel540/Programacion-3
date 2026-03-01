///. Simulador de Cajero Automático (Clase Cuenta)
//Objetivo: Crear una clase que gestione el dinero de un usuario.

//Clase: CuentaBancaria.
//Propiedades: Titular(string) y Saldo(decimal).
//Métodos:
//ConsultarSaldo(): Muestra el saldo actual.
//Depositar(decimal cantidad): Suma al saldo (validar que la cantidad sea positiva).
//Retirar(decimal cantidad): Resta al saldo (validar que tenga fondos suficientes).
//Interacción: El usuario debe ingresar su nombre al inicio y luego elegir opciones de un menú para
//depositar o retirar dinero repetidamente.


using System.Security.Cryptography;
using EjerciciosPOO.Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Ejercicios
{
    internal class CuentaBancaria
    {
        public String Titular { get; set; }

        public decimal Saldo { get; set; }

        public void ConsultarSaldo()
        {
            Console.WriteLine("Saldo actual: " + Saldo);
        }

        public void Depositar(decimal cantidad)
        {
            if (cantidad >= 0)
            {
                Saldo = Saldo + cantidad;
                Console.WriteLine("Saldo agregado");
            }
            else
            {
                Console.WriteLine("Usted no puede agregar una cantidad negativa");
            }
        }

        public void Retirarar(decimal cantidad)
        {
            if (cantidad < Saldo && cantidad > 0)
            {
                Saldo = Saldo - cantidad;
                Console.WriteLine("Saldo retirado");
            }
            else if (cantidad > Saldo)
            {
                Console.WriteLine("No tienes saldo suficiente para retirar");
            }
            else
            {
                Console.WriteLine("No puedes ingresar un valor negativo");
            }
        }

        public static void Ejectuar()
           
        {
            Console.WriteLine("EJERCICIO #1");
            CuentaBancaria cuenta = new CuentaBancaria();
            cuenta.Saldo = 0;
            int op;
            Console.WriteLine("Ingrese el titular: ");
            cuenta.Titular = Console.ReadLine();
            do
            {
                Console.WriteLine("========= MENU ========= ");
                Console.WriteLine("1. CONSULTAR SALDO");
                Console.WriteLine("2. DEPOSITAR SALDO");
                Console.WriteLine("3. RETIRQAR SALDO");
                Console.WriteLine("0. SALIR");
                Console.WriteLine("Ingrese una opcion");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        cuenta.ConsultarSaldo();
                        break;

                    case 2:
                        Console.WriteLine("Cuanto saldo desea depositar");
                        decimal can = decimal.Parse(Console.ReadLine());
                        cuenta.Depositar(can);
                        break;

                    case 3:
                        Console.WriteLine("Cuanto saldo desea retirar");
                        decimal can2 = decimal.Parse(Console.ReadLine());
                        cuenta.Retirarar(can2);
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
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
