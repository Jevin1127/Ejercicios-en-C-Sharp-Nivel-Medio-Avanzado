using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Varios_2
{
    internal abstract class Circulo
    {
        protected double Radio { get; set; }

        public virtual double leerRadio()
        {
            return Radio;
        }

        public virtual double Area()
        {
            return System.Math.PI * Math.Pow(Radio, 2);
        }
        public virtual double Circunferencia()
        {
            return 2 * System.Math.PI * Radio;
        }
    }
}
