using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas_Practica__Vehiculo_
{
    abstract class VehiculodePasajero : Vehiculo 
    {
        abstract class VehiculodePasajerosinMotor : VehiculodePasajero
        {
            abstract class Bicicleta : VehiculodePasajerosinMotor
            {
            }
        }

        abstract class VehiculodePasajeroconMotor : VehiculodePasajero
        {
            abstract class cicloMotor : VehiculodePasajerosinMotor
            {
            }

              /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            abstract class Bus : VehiculodePasajerosinMotor
            {
                abstract class microBus : Bus
                {
                }
                abstract class autoBus : Bus
                {
                }
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            abstract class Coche : VehiculodePasajerosinMotor
            {
                abstract class Familiar : Coche
                {
                }
                abstract class Deportivo : Coche
                {
                    abstract class BMW : Deportivo
                    {

                    }
                    abstract class Toyota : Deportivo
                    {
                    }
                }
                abstract class Lujo : Coche
                {
                }
                abstract class Motor4x4 : Coche
                {
                }
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            abstract class trenPasajero : VehiculodePasajeroconMotor
            {
            }
        }

    }

}
