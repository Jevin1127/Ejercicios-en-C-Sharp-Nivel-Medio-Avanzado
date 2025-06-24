using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viejo_Oeste_Practica
{
	class PuebloDelOeste
	{
		public int establos;

		public String locacion;

		public int tiempo;
		public int cantinas;
		public int comisarios;
		public int alborotadores;

		public PuebloDelOeste()
		{
			establos = 3;
			locacion = "Oeste de los Estados Unidos";
			tiempo = 1850;
		}

		public void mostrarPueblo()
		{
			Console.Write("Nos adentramos en una pequeña epoca donde habian cosas incorrectas y exuberantes");
			Console.WriteLine("y la pianola y los robos a bancos era el tiktok de esos tiempos!");
			Console.WriteLine();
			Console.WriteLine("Nos remontamos al " + locacion);
			Console.WriteLine("Eran los años: " + tiempo);
			Console.WriteLine("Aledaño a un desierto, la historia comienza cerca del banco donde habian " + establos + " establos cerca");
			Console.WriteLine("Cerca de este sitio hay "+  cantinas + " Cantinas");
			Console.WriteLine("Este sitio es un lugar hostil asi que lo resguardan " + comisarios + " Comisario");
			Console.WriteLine("Ya que siempre hay " + alborotadores + " alborotadores haciendo de las suyas!");
		}

	}
}
