using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Varios
{
    internal abstract class Nombre
    {
        protected string nombre { get; set; }
        protected string primerApellido { get; set; }
        protected string segundoApellido { get; set; }

        public Nombre(string nombre, string primerApellido, string segundoApellido)
        {
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
        }

        public virtual string Leer_Nombre()
        {
            return nombre;
            return primerApellido;
            return segundoApellido;
        }
        public virtual void mostrar()
        {
            Leer_Nombre();
        }
     }
}
