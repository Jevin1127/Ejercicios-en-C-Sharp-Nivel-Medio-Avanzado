using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas_Practica
{
    class Coche : Vehiculo 
    {
        private string Carro { get; set; }

        public override string Conducir()
        {
            return "Mueve las Ruedas";
        } 
    }
}
