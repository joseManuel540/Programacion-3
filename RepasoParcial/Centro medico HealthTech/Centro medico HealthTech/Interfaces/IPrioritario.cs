/* Interfaz: Crea IPrioritario con un método AplicarDescuento() . Si la especialidad es Pediatría, tiene un 20%
de descuento.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_medico_HealthTech.Interfaces
{
    public interface IPrioritario
    {
        double AplicarDescuento();
    }
}
