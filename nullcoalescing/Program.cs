using System;
using System.Collections.Generic;
using System.Linq;

namespace NullCoalescing
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string inputName = null;

			string personName;
			if (inputName == null)
				personName = "no name";
			else
				personName = inputName;
			Console.WriteLine(personName);


			inputName = null;

			personName = inputName == null ? "no name" : inputName;
			Console.WriteLine(personName);


			inputName = null;

			personName = inputName ?? "no name";
			Console.WriteLine(personName);


			// Encadenamiento
			inputName = null;

			personName = inputName ?? GetRandomName() ?? TryGetName() ?? "no name";
			Console.WriteLine(personName);

			int? teamAPoints = null;
			int? teamBPoints = 5;

			var difference = (teamAPoints ?? 0) - (teamBPoints ?? 0);
			Console.WriteLine("Difference " + difference);

			// Invalid:

			//var invalid = personName ?? teamAPoints;

			var randomOrNot = MainClass.Random?.Next(0, 10) ?? 0;

		}

		public static string TryGetName()
		{
			Console.WriteLine("Escribe el nombre");
			var line = Console.ReadLine();
			return String.IsNullOrWhiteSpace(line) ? null : line;
		}

		public static string GetRandomName()
		{
			if (DateTime.Now.Second % 5 == 0)
				return Guid.NewGuid().ToString().Substring(0, 4);
			else
				return null;
		}

		private static Random _random;
		public static Random Random
		{
			get
			{
				return _random ?? (_random = new Random(DateTime.Now.Second));
			}
		}

	}
}
