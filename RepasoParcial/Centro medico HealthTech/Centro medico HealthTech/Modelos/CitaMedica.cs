/*1. Estructura: Crea una clase CitaMedica con Paciente , Especialidad (Enum: General, Pediatria, Odontologia) y
CostoBase .*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centro_medico_HealthTech.Enums;
using Centro_medico_HealthTech.Interfaces;

namespace Centro_medico_HealthTech.Modelos
{
    public class CitaMedica : IPrioritario
    {
        public string Paciente { get; set; }
        public Especialidad Especialidad { get; set; }
        public double CostoBase { get; set; }


        public CitaMedica(string paciente, Especialidad especialidad, double costoBase)
        {
            Paciente = paciente;
            Especialidad = especialidad;
            CostoBase = costoBase;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Paciente: " + Paciente);
            Console.WriteLine("Especialidad : " + Especialidad);
            Console.WriteLine("Costo Base: " + CostoBase);
        }

        public double AplicarDescuento()
        {
            if (Especialidad == Especialidad.Pediatra)
            {
                double temp = CostoBase*0.2;
                return CostoBase - temp;
            }
            return CostoBase;
        }
    }

   
}
