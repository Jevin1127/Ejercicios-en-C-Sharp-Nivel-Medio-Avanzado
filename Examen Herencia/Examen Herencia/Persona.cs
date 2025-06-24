using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Herencia
{
    class Persona
    {
        protected int Id { get => Id; set => Id = value; }
        protected string PrimerNombre { get => PrimerNombre; set => PrimerNombre = value; }
        protected string SegundoNombre { get => SegundoNombre; set => SegundoNombre = value; }
        protected string PrimerApellido { get => PrimerApellido; set => PrimerApellido = value; }
        protected string SegundoApellido { get => SegundoApellido; set => SegundoApellido = value; }

        public Persona()
        {
        }

        public Persona(string primerNombre, string segundoNombre, string primerApellido, string segundoApellido)
        {
            this.PrimerNombre = primerNombre;
            this.SegundoNombre = segundoNombre;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
        }

        public string GetNombreCompleto() 
        {
            return PrimerApellido + PrimerApellido;
        }

        public string GetApellidos() 
        {
            return PrimerApellido + SegundoApellido;
        }
    }
}