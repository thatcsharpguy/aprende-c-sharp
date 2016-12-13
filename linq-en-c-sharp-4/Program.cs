using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq4
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			var coleccion1 = new int[] { 0, 1, 2, 3, 4, 5 };
			var coleccion2 = new int[] { 4, 5, 6, 7, 8, 9 };

			var combinados = coleccion1.Zip(coleccion2, (a, b) => a * b);
			PrintInline(combinados);
			var nombres = new String[] { "A", "B", "A", "C", "D", "A" };
			var apellidos = new String[] { "Z", "X", "Y", "Y", "W", "Z" };

			var personas = nombres.Zip(apellidos, (n, a) => new Persona { Nombre = n, Apellido = a }).OrderBy(p => p.Apellido);
			var otrasPersonas = nombres.Zip(apellidos.Reverse(), (n, a) => new Persona { Nombre = n, Apellido = a }).OrderBy(p => p.Apellido);
			Print(personas);
			Print(otrasPersonas);

			var concatenados = coleccion1.Concat(coleccion2);
			var unidos = coleccion1.Union(coleccion2);
			PrintInline(concatenados);
			PrintInline(unidos);

			var interseccion = coleccion1.Intersect(coleccion2);
			PrintInline(interseccion);

			var except = coleccion1.Except(coleccion2);
			PrintInline(except);


			var secuencia1 = Enumerable.Range(0, 4);
			var secuencia2 = Enumerable.Range(0, 4);
			var secuencia3 = Enumerable.Range(1, 4);

			var sonIguales = secuencia1.SequenceEqual(secuencia2);
			Console.WriteLine("Son iguales " + sonIguales);

			var sonIguales1 = secuencia1.SequenceEqual(secuencia3);
			Console.WriteLine("Son iguales " + sonIguales1);

			var distintos = concatenados.Distinct();
			PrintInline(distintos);

			var personasDistintas = personas.Distinct();
			Console.WriteLine("Personas distintas por apellido");
			Print(personasDistintas);

			var personasDistintasNombre = personas.Distinct(new NameEqualityComparer());
			Console.WriteLine("Personas distintas por nombre");
			Print(personasDistintasNombre);


			bool todosDivisiblesEntre2 = secuencia1.All(i => i % 2 == 0);
			bool algunoDivisibleEntre2 = secuencia1.Any(i => i % 2 == 0);

			Console.WriteLine("Todos divisibles: " + todosDivisiblesEntre2);
			Console.WriteLine("Alguno divisible: " + algunoDivisibleEntre2);

			Console.Read();

		}

		static void PrintInline<T>(IEnumerable<T> collection)
		{
			var enumerator = collection.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Console.Write(enumerator.Current);
				Console.Write("  ");
			}
			Console.WriteLine();
		}

		static void Print<T>(IEnumerable<T> collection)
		{
			var enumerator = collection.GetEnumerator();
			while (enumerator.MoveNext())
				Console.WriteLine(enumerator.Current);
		}
	}
}
