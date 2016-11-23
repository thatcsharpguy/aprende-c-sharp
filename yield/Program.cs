using System;
using System.Linq;
using System.Collections.Generic;

namespace Yield
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Normal collection");
			foreach (var m in GetMultiplesOf(2, 1, 10))
			{
				Console.WriteLine($"{m} es multiplo de 2");
			}
			Console.WriteLine();

			Console.WriteLine("Yield collection");
			foreach (var m in YieldMultiplesOf(2, 1, 10))
			{
				Console.WriteLine($"{m} es multiplo de 2");
			}
			Console.WriteLine();


			Console.WriteLine("Normal collection");
			foreach (var m in GetMultiplesOf(3, 15, 67))
			{
				if (m == 30)
				{
					Console.WriteLine($"¡Encontré 30!");
					break;
				}
			}
			Console.WriteLine();
			Console.WriteLine("Yield collection");
			foreach (var m in YieldMultiplesOf(3, 15, 67))
			{
				if (m == 30)
				{
					Console.WriteLine($"¡Encontré 30!");
					break;
				}
			}
			Console.WriteLine();


			var get = GetMultiplesOf(2, 320, 335).Skip(3).First();
			Console.WriteLine($"El cuarto multiplo es {get}");		
			Console.WriteLine();
			var yield = YieldMultiplesOf(2, 320, 335).Skip(3).First();
			Console.WriteLine($"El cuarto multiplo es {yield}");


			Console.WriteLine();
			Console.WriteLine("Prime factors of 10080");
			foreach (var factor in PrimeFactors(10080))
			{
				Console.Write(factor + " ");
			}
			Console.WriteLine();


			Console.WriteLine();
			Console.WriteLine("Randoms:");
			var random = new NotSoRandom();
			var numbers = random.Where(r => r % 3 == 0).Take(10);

			//var numbers = random.Where(r => r % 3 == 0).Take(10).ToList();
			Console.WriteLine("Aún no ocurre nada...");
			foreach (var n in numbers)
			{
				Console.WriteLine(n);
			}

			// WARNING: 
			//var allRandoms = random.ToArray();
		}

		static IEnumerable<int> GetMultiplesOf(int n, 
		                                int start, 
		                                int end)
		{
			List<int> multiples = new List<int>();
			for (int i = start; i < end; i++)
			{
				if (i % n == 0)
				{
					Console.WriteLine($"{i} GetMultiplesOf");
					multiples.Add(i);
				}
			}
			return multiples;
		}

		static IEnumerable<int> YieldMultiplesOf(int n, 
		                                  int start, 
		                                  int end)
		{
			for (int i = start; i < end; i++)
			{
				if (i % n == 0)
				{
					Console.WriteLine($"{i} YieldMultiplesOf");
					yield return i;
				}
			}
		}

		public static IEnumerable<int> PrimeFactors(int n)
		{
			// Print the number of 2s that divide n
			while (n % 2 == 0)
			{
				yield return 2;
				n = n / 2;
			}

			// n must be odd at this point.  So we can skip one element (Note i = i +2)
			for (int i = 3; i <= Math.Sqrt(n); i += 2)
			{
				// While i divides n, print i and divide n
				while (n % i == 0)
				{
					yield return i;
					n = n / i;
				}
			}

			// This condition is to handle the case whien n is a prime number
			// greater than 2
			if (n > 2)
				yield return n;
		}
	}

}
