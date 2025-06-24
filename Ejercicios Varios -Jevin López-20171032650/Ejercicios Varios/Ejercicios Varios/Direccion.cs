using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Varios
{
    internal class Direccion : Nombre
    {

        protected string calle { get; set; }
        protected string ciudad { get; set; }
        protected string provincia { get; set; }
        protected string codigoPostal { get; set; }

        public Direccion(string nombre, string primerApellido, string segundoApellido) : base(nombre, primerApellido, segundoApellido)
        {
        }

        public virtual string nueva_Direccion()
        {
            return calle;
            return ciudad;
            return provincia;
            return codigoPostal;
        }
        public virtual string nuevo_Nombre()
        {
            return nombre;
            return primerApellido;
            return segundoApellido;
        }

        public override void mostrar()
        {
            nuevo_Nombre();
            nueva_Direccion();
        }
    }
}
