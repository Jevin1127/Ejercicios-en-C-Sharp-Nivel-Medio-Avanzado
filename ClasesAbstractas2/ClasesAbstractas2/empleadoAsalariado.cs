using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas2
{
    internal class empleadoAsalariado : Empleado
    {
        protected int salarioSemanal { get; set; }
        virtual public string EmpleadoAsalariado()
        {
           return primerNombre;
           return apellidoFaterno;
        }
        override public int numerodeseguroSocial()
        {
            return NSS;
        }

        virtual public int salariosemanal()
        {
            return salarioSemanal;
            
        }

        virtual public int IngresosempleadoAsalariado()
        {
           return salarioSemanal;
        }
    }
}
