using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas_Practica__Futbolista_
{
    class Defensa : Futbolista 
    {
        public void quitarelBalon()
        {
            Console.WriteLine("El defensa quita el balón al delantero");
        }
        public void Defender()
        {
            Console.WriteLine("El defensa defiende la porteria");
        }
        public void pararelBalon()
        {
            Console.WriteLine("El defensa para el balón que llevaba el delantero");
        }
    }
}
