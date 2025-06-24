using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viejo_Oeste_Practica
{
    class Villanos : Humanos
    {
        public String colorBigote;
        public String colorSombrero;
        protected String aspecto;
        protected int ebriedad;
        protected int numeroDeDamiselas;
        public Humanos damisela;
        public Villanos()
        {
            aspecto = "Malo";
            ebriedad = 0;
            numeroDeDamiselas = 0;
        }
        public void tomarWhiskey()
        {
            ebriedad++;
        }
        public int queTanEbrioEstoy()
        {
            return ebriedad;
        }

        public void secuestrarDamisela(Humanos damisela)
        {
            this.damisela = damisela;
            numeroDeDamiselas++;
            Console.WriteLine("El Villano ha secuestrado a " + damisela.comoTeLlamas());
        }
                
        public void mostrarVillano()
        {
            Console.WriteLine("Apesar de que los alborotadores hacen fechorias hay un villano muy temido...");
            Console.WriteLine("Este villano siempre hace sus apariciones para robarse damiselas!");
            Console.WriteLine("Este tipo tenia un aspecto " + aspecto);
            Console.WriteLine("Con su sobrero de color " + colorSombrero);
            Console.WriteLine("Con un gran bigote de color " + colorBigote);
            Console.WriteLine("Cabalgando en su caballo " + nombreCaballo + " imponia su respeto por todo el oeste!");
            Console.WriteLine("Su lema era: si en tu desayuno no hay whiskey tu no eres un " + sexo + "!!");
            Console.WriteLine("Y si! En su desayuno tomaba Whiskey " + preferenciaWhiskey);
            Console.WriteLine("Por los momentos este tipo tenia un nivel de ebriedad en " + ebriedad);
            Console.WriteLine("en su recuento de la semana tenia anotado que solo habia secuestrado en la semana " + numeroDeDamiselas + " damicelas");
        }

        public void tramaFinal()
        {
            Console.WriteLine();
            Console.WriteLine("Mary el villano se encontraron en el bar!");
            Console.WriteLine("Habia tención en el sitio... parecia que ya se habian visto...");
            Console.WriteLine("Este villano siempre hace sus apariciones para robarse damiselas!");
            Console.WriteLine("El villano ya habia desayunado, y su grado de ebriedad era " + queTanEbrioEstoy());
            Console.WriteLine("Mary le impone respeto y le pide que se aleje de ella!");
            Console.WriteLine("El villano alterano y ebrio exclamó:");
            Console.WriteLine("Nadie me dice que hacer!!!");
            Console.WriteLine("Tomó a Mary a la fuerza y en su caballo " + nombreCaballo + " y salieron del bar");
        }
    }
}
