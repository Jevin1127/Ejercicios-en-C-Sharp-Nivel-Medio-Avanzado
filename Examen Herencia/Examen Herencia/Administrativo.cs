using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Herencia
{
    class Adminitrativo : Empleado
    {
        private string Area { get => Area; set => Area = value; }
        public string NumeroExtencion { get => NumeroExtencion; set => NumeroExtencion = value; }

        public Adminitrativo() { }
    }
}
