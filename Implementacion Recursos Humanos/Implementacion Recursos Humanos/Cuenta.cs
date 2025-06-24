using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion_Recursos_Humanos
{
    internal class Cuenta
    {
        private string numeroCuenta { get; set; }
        private DateTime fechaApertura { get; set; }
        private decimal Sueldo { get; set; }
        private List<Transaccion> Movimientos { get; set; }

        public void Depositar(double Monto)
        {
        }
    }
}
