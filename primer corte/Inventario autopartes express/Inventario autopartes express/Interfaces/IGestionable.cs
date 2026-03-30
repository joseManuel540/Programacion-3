using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_autopartes_express.Interfaces
{
    public interface IGestionable
    {
        void Crear();
        void Leer();
        void Actualizar();
        void Eliminar();
    }
}
