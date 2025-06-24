using System;

namespace Viejo_Oeste_Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            PuebloDelOeste sweatyPost = new PuebloDelOeste();
            sweatyPost.cantinas = 2;
            sweatyPost.comisarios = 1;
            sweatyPost.alborotadores = 5;
            sweatyPost.mostrarPueblo();

            Villanos maurice = new Villanos();
            maurice.colorSombrero = "negro";
            maurice.colorBigote = "rojo";
            maurice.sexo = "hombre";
            maurice.nombreCaballo = "Beer Gut";
            maurice.preferenciaWhiskey = "Jack Daniels";
            maurice.mostrarVillano();

            Humanos mary = new Humanos();
            mary.sexo = "mujer";
            mary.nombreCaballo = "Midnight";
            mary.preferenciaWhiskey = "solo";
            mary.nombre = "Mary";
            mary.mostrarHumanos();

            maurice.tomarWhiskey();
            maurice.tomarWhiskey();
            maurice.tomarWhiskey();
            maurice.tomarWhiskey();
            maurice.tomarWhiskey();
            maurice.tramaFinal();
            maurice.secuestrarDamisela(mary);
        }
    }
}
