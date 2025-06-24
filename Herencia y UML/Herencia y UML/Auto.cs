using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_y_UML
{
    class Auto : Vehiculo
    {
        private string Estilo { get => Estilo; set => Estilo = value; }

        public Auto() { }

        public Auto(int tamaño, string color, string marca, string modelo, bool disponible, string estilo)
        {
            this.Tamaño = tamaño;
            this.Color = color;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Disponible = disponible;
            this.Estilo = estilo;
        }
    }
}
