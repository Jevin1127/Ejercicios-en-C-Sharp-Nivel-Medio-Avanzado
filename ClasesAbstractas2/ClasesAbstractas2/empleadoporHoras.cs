using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas2
{
    internal class empleadoporHoras : empleadoAsalariado
    {
        protected int Sueldo { get; set; }
        protected int Horas { get; set; }
        protected int Empleadoporhoras { get; set; }
        virtual public string empleadoporhoras()
        {
            return primerNombre;
            return apellidoFaterno;
        }
        override public int numerodeseguroSocial()
        {
            return NSS;
        }
        virtual public int sueldoporHoras()
        {
            return Sueldo;
        }

        virtual public int horasTrabajadas()
        {
            return Horas;
        }

        virtual public void IngresosempleadoporHoras()
        {
            if (Horas <= 40) 
            {
                Empleadoporhoras = Sueldo * Horas;
            }
            else if (Horas > 40)
            {
                Empleadoporhoras = (int)((Horas - 40) * Sueldo * 1.5);
            }
        }
    }
}
