using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion_e_Implementación
{
    class Coche
    {
        private int NumerodeCochesVendidos { get; set; }
        private string Modelo { get; set; }
        private string Color { get; set; }
        private decimal Precio { get; set; }
        public Motor MiMotor { get; set; }
        public SistemaFrenos MiSistemaFrenos { get; set; }
        public SistemaTransmision MiSistemaTransmision { get; set; }
        public Chasis MiChasis { get; set; }

    }
}
