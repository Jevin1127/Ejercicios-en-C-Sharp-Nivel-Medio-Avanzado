using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas_Practica__Vehiculo_
{
    abstract class VehiculodeCarga : Vehiculo
    {
        abstract class Camion : VehiculodeCarga
        {
        }
        abstract class trendeCarga : VehiculodeCarga
        {
        }
    }
}
