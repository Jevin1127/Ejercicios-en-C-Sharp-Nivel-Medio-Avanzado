using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas2
{
    internal class empleadoporComision : empleadoporHoras
    {
        protected int ventasBrutas { get; set; }
        protected int tarifadeComision { get; set; }

        virtual public string EmpleadoporComision()
        {
            return primerNombre;
            return apellidoFaterno;
        }
        override public int numerodeseguroSocial()
        {
            return NSS;
        }

        virtual public int ventasbrutas()
        {
            return ventasBrutas;
        }

        virtual public int tarifadecomision()
        {
            return tarifadeComision;
        }

        virtual public int Ingresosempleadoporcomision()
        {
            return tarifadeComision * ventasBrutas; 
        }
    }
}
