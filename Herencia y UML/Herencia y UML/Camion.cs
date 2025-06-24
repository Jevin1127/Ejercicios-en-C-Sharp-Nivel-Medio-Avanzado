using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_y_UML
{
    class Camion : Vehiculo 
    {
        private double Longitud { get => Longitud; set => Longitud = value; }
        private bool Traccion4Ruedas { get => Traccion4Ruedas; set => Traccion4Ruedas = value; }
     
        public Camion () { }

        public Camion(int tamaño, string color, string marca, string modelo, bool disponible, double longitud, bool traccion4ruedas) 
        {
            this.Tamaño = tamaño;
            this.Color = color;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Disponible = disponible;
            this.Longitud = longitud;
            this.Traccion4Ruedas = traccion4ruedas;
        }
    }
}
