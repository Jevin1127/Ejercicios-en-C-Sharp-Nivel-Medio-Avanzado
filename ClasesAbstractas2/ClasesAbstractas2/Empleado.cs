using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas2
{
    internal abstract class Empleado
    {
        protected string primerNombre { get; set; }
        protected string apellidoFaterno { get; set; }
        protected int NSS { get; set; }

        virtual public int numerodeseguroSocial()
        {
            return NSS;
        }
    }
}
