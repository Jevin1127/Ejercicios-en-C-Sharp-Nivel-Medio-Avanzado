using System;

namespace Herencia_y_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculos = new Vehiculo();
            Auto auto = new Auto();
            Camion camion = new Camion();

            Console.WriteLine(vehiculos.ToString());
            Console.WriteLine(auto.ToString());
            Console.WriteLine(camion.ToString());
        }
    }
}
