using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas_Practica
{
    abstract class Vehiculo
    {
        private string Color { get; set; }
        private DateTime añodeFabricacion { get; set; }

        public virtual string Conducir()
        {
            return "Un vehiculo se maneja";
        }
    }
}
