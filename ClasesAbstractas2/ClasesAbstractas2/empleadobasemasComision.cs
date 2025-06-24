using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas2
{
    internal class empleadobasemasComision : empleadoporComision
    {
        protected int salarioBase { get; set; }

        virtual public string EmpleadoporComisionconSalarioBase()
        {
            return primerNombre;
            return apellidoFaterno;
        }
        override public int numerodeseguroSocial()
        {
            return NSS;
        }

        override public int ventasbrutas()
        {
            return ventasBrutas;
        }

        override public int tarifadecomision()
        {
            return tarifadeComision;
        }
        virtual public int salariobase()
        {
            return salarioBase;
        }

        virtual public int Ingresosempleadobasemascomision() 
        {
            return (tarifadeComision * ventasBrutas) + salarioBase;             
        }
    }
}
