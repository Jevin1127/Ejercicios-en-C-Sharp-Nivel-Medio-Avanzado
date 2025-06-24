using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_y_UML
{
    class Vehiculo
    {
        protected int Tamaño { get => Tamaño; set => Tamaño = value; }
        protected string Color { get => Color; set => Color = value; }
        protected string Marca { get => Marca; set => Marca = value; }
        protected string Modelo { get => Modelo; set => Modelo = value; }
        protected bool Disponible { get => Disponible; set => Disponible = value; }

        public void Rentar() { }
        public void Agregar() { }
    }
}
