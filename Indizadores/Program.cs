using System;
using System.Collections.Generic;

namespace Indizadores
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var lista = new List<int>() { 1,2,3,4, 5 };

			Console.WriteLine(String.Format("{0} {1} {2} {3} {4}", 
			                                lista[0], 
			                                lista[1], 
			                                lista[2], 
			                                lista[3], 
			                                lista[4]));
			lista[0] = 9;
			lista[4] = 10;

			Console.WriteLine(String.Format("{0} {1} {2} {3} {4}",
											lista[0],
											lista[1],
											lista[2],
											lista[3],
											lista[4]));

			Dictionary<string, int> numeros = new Dictionary<string, int>
			{
				{ "uno", 1 },
				{ "dos", 2 },
				{ "tres", 3 },
				{ "cinco", 5 },
				{ "cuatro", 4 }
			};

			Console.WriteLine(numeros["uno"]);
			Console.WriteLine(numeros["cinco"]);

			var indizador = new Indexer();
			var retorno = indizador["hola"];
			indizador["feliz"] = 2017;
			Console.WriteLine("Valor de retorno {0}", retorno);

			var otroIndizador = new Indexer();
			Console.WriteLine(indizador[otroIndizador]);

			 indizador[123.456d] = otroIndizador;

			var resultado1 = indizador[10, false, 5];
			Console.WriteLine(resultado1);
		}
	}
}
