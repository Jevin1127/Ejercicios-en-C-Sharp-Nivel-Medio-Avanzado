using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion_Recursos_Humanos
{
    internal class empleadoporComision : Empleado
    {
        private decimal ventasBrutas { get; set; }
        private float tarifaComision { get; set; }
    }
}
