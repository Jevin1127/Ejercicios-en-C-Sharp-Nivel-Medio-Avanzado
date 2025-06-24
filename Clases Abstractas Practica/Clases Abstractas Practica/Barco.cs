using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas_Practica
{
    class Barco : Vehiculo
    {
        public override string Conducir()
        {
            return "Mueve el barco y los propulsores";
        }
    }
}
