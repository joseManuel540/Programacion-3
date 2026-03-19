/*Centro Médico "HealthTech" (Lógica y Enums)
Objetivo: Gestionar estados y cálculos basados en tipos de objetos.
¿Qué debes hacer?
1. Estructura: Crea una clase CitaMedica con Paciente , Especialidad (Enum: General, Pediatria, Odontologia) y
CostoBase .
2. Interfaz: Crea IPrioritario con un método AplicarDescuento() . Si la especialidad es Pediatría, tiene un 20%
de descuento.
3. Menú Principal:
1. Agendar Cita: Pedir datos por teclado (incluyendo el enum por número).
2. Ver Factura: Mostrar el nombre del paciente, la especialidad y el precio final (aplicando descuento si
aplica).
3. Cambiar Especialidad: Buscar una cita por nombre de paciente y permitir cambiar su especialidad.
0. Salir*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centro_medico_HealthTech.Enums;
using Centro_medico_HealthTech.Interfaces;
using Centro_medico_HealthTech.Modelos;

namespace Centro_medico_HealthTech
{
    internal class Program
    {
        private static List<IPrioritario> citas = new List<IPrioritario>();
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE CITAS MEDICAS ===");

            int opcion;
            do
            {
                MostrarMenu();
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    ProcesarOpcion(opcion);
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcion != 6);
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Agendar");
            Console.WriteLine("2. Facturar");
            Console.WriteLine("3. Cambiar Especialidad");
            Console.WriteLine("0. Salir");
            Console.WriteLine("=====================");
        }

        private static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    AgendarCita();
                    break;
                case 2:
                    MostrarCitas();
                    break;
                case 3:
                    CambiarEspecialidad();
                    break;
                case 0:
                    Console.WriteLine("¡Gracias por usar el Sistema de Centro medico");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        private static void AgendarCita()
        {
            Console.WriteLine("\n=== AGENDAR CITA ===");
            Console.Write("Nombre Paciente: ");
            string nombre = Console.ReadLine();

            Console.Write("Costo base: ");
            double costobase = double.Parse(Console.ReadLine());

            Especialidad especialidad = SeleccionarEspecialidad();

            var cita = new CitaMedica(nombre, especialidad, costobase);
            citas.Add(cita);

            Console.WriteLine("cita agregada exitosamente!");
        }

        private static Especialidad SeleccionarEspecialidad()
        {
            Console.WriteLine("\nSeleccione una especialidad:");
            var especialidad = Enum.GetValues(typeof(Especialidad));

            for (int i = 0; i < especialidad.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {especialidad.GetValue(i)}");
            }

            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine()) - 1;

            return (Especialidad)especialidad.GetValue(opcion);
        }

        private static void MostrarCitas()
        {
            Console.WriteLine("\n=== CITAS MEDICAS ===");

            if (citas.Count == 0)
            {
                Console.WriteLine("No hay citas disponibles.");
                return;
            }

            for (int i = 0; i < citas.Count; i++)
            {
                Console.WriteLine($"\n--- Cita {i + 1} ---");
                if (citas[i] is CitaMedica cita)
                {
                    cita.MostrarInformacion();
                    Console.WriteLine("Precio final: " + cita.AplicarDescuento());
                }
            }
        }

        private static void CambiarEspecialidad() 
        {
            Console.WriteLine("Ingrese el nombre del paciente que quiere cambiar la especialidad: ");
            string paciente = Console.ReadLine();
            bool encontrado = false;
            for (int i = 0; i < citas.Count; i++)
            {
                if (citas[i] is CitaMedica cita)
                {
                    if (cita.Paciente.Equals(paciente))
                    {
                        Especialidad especialidad = SeleccionarEspecialidad();
                        cita.Especialidad = especialidad;
                        encontrado = true;
                    }
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontro el paciente");
            }
        }
    }
}
