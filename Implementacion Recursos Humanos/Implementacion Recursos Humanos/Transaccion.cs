using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion_Recursos_Humanos
{
    internal class Transaccion
    {
        private decimal codigoTransaccion { get; set; }
        private DateTime fechaTransaccion { get; set; }
        private decimal Monto { get; set; }
        private string Usuario { get; set; }
    }
}