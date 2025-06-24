using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas_Practica__Futbolista_
{
    abstract class Futbolista
    {
        private string Nombre { set; get; }
        private int Edad { set; get; }
        private int Altura { set; get; }
        private string Nacionalidad { set; get; }
        private int Numero { set; get; }

        public virtual void Correr()
        {
            Console.WriteLine("El futbolista corre");
        }
        public virtual void Driblar()
        {
            Console.WriteLine("El futbolista domina el balón mientras corre");
        }
        public virtual void Regatear()
        {
            Console.WriteLine("El futbolista regatea el balón");
        }
        public virtual void Lanzar()
        {
            Console.WriteLine("El futbolista se lanza a la cancha");
        }
    }
}
