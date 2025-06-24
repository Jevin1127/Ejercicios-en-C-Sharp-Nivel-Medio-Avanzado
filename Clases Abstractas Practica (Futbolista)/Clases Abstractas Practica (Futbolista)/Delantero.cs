using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas_Practica__Futbolista_
{
    class Delantero : Futbolista
    {
        public void tirarPuerta()
        {
            Console.WriteLine("El delantero hace un tiro a la puerta del portero");
        }
        public void lanzarPenalty()
        {
            Console.WriteLine("El delantero hace un y lo falla como el duro que es");
        }
        public void lanzarFalta()
        {
            Console.WriteLine("El delantero le hace una falta al portero y le sacan roja, es un duro");
        }
    }
}
