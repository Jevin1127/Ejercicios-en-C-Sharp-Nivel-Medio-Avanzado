using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion_Recursos_Humanos
{
    internal class empleadoporHoras : Empleado
    {
        private decimal Sueldo { get; set; }
        public float Horas { get; set; }
    }
}
