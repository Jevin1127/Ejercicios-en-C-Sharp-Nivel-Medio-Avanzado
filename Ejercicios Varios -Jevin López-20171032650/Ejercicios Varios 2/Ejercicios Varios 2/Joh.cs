using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Varios_2
{
    internal abstract class Cilindro : Circulo 
    {
        protected double Altura { get; set; }

        public override double Area()
        {
            return 2 * System.Math.PI * Radio * Altura + 2 * System.Math.PI * Math.Pow(Radio, 2);
        }

        public virtual double Volumen()
        {
            return System.Math.PI * Math.Pow(Radio, 2) * Altura;
        }
    }
}
