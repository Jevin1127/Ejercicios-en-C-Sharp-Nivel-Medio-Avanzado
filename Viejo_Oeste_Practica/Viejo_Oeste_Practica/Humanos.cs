using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viejo_Oeste_Practica
{
    class Humanos
    {
        protected int piernas;
        protected int brazos;
        protected int ojos;
        protected int nariz;
        protected int boca;
        public String nombre;
        public String sexo;
        public String nombreCaballo;
        public String preferenciaWhiskey;


        public Humanos()
        {
            piernas = 2;
            brazos = 2;
            ojos = 2;
            nariz = 1;
            boca = 1;
        }
        public String comoTeLlamas()
        {
            return nombre;
        }

        public void mostrarHumanos()
        {
            Console.WriteLine();
            Console.WriteLine("En el lugar habia una damicela no tan damicela...");
            Console.WriteLine("Su nombre era " + nombre);
            Console.WriteLine("Una " + sexo + " tenaz! Cabalgando a su caballo " + nombreCaballo + " y eran la sensación del pueblo!");
            Console.WriteLine("A " + nombre + " le gustaba el whiskey " + preferenciaWhiskey);
        }
    }
}

