using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Herencia
{
    class Estudiante : Persona
    {
        private string TipoCarrera { get => TipoCarrera; set => TipoCarrera = value; }

        public Estudiante() { }

    }
}
