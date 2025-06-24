using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Herencia
{
    class Empleado : Persona
    {
        protected TimeSpan FechaIngreso { get => FechaIngreso; set => FechaIngreso = value; }
        protected TimeSpan FechaSalida { get => FechaSalida; set => FechaSalida = value; }

        public Empleado() { }

        public Empleado(string primerNombre, string segundoNombre, string primerApellido, string segundoApellido)
        {
            this.PrimerNombre = primerNombre;
            this.SegundoNombre = segundoNombre;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
        }
        public void Despedir() { }

    }
}
