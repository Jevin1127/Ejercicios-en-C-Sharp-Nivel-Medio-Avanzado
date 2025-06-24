using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas_Practica__Futbolista_
{
    class Portero : Futbolista
    {
        public void Parar()
        {
            Console.WriteLine("El portero para el balón");
        }
        public void Sacar()
        {
            Console.WriteLine("El portero saca el balon de la porteria");
        }
        public void pararPenalty()
        {
            Console.WriteLine("El portero para el penalty que el futbolista");
        }
    }
}
