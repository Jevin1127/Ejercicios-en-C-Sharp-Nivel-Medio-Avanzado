using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Herencia
{
    class Docente : Empleado
    {
        protected bool Estado { get => Estado; set => Estado = value; }

        public Docente() { }

    }
}
