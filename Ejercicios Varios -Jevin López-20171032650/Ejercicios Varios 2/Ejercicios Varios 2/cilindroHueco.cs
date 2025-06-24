using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Varios_2
{
    internal abstract class cilindroHueco : Cilindro
    {
        protected double radioInterno { get; set; }

        public virtual double Longitud()
        {
            return 2 * System.Math.PI * (Math.Pow(Radio, 2) - Math.Pow(radioInterno, 2))
                + 2 * System.Math.PI * Radio * Altura + 2 * System.Math.PI * Altura * radioInterno;
        }

        public override double Volumen()
        {
            return System.Math.PI * (Math.Pow(Radio, 2) - Math.Pow(radioInterno, 2)) * Altura;
        }
    }
}
