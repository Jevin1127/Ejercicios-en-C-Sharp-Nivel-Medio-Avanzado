using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion_Recursos_Humanos
{
    internal class Empleado
    {
        private string primerNombre { get; set; }
        private string primerApellido { get; set;}
        private string segundoNombre { get; set; }
        private string segundoApellido { get; set; }
        public Cuenta miCuenta { get; set; }
        public decimal calcularSalario()
        {
            return 0;
        }

    }
}
