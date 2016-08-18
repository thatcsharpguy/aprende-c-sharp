using System;

namespace Events
{
	class MainClass
	{
		static Generator g;

		public static void Main(string[] args)
		{
			Console.WriteLine("Escribe un nombre y presiona enter");
			var name = Console.ReadLine();

			g = new Generator(name);


			g.GeneratingNumber += G_GeneratingNumber;

			g.EvenNumberGenerated += (sender, number) => 
			{
				Console.WriteLine("Se generó el número: " + number + " (manejador 1)");
			};

			g.EvenNumberGeneratedAction += (obj) => 
			{  
				Console.WriteLine("Se generó el número: " + obj + " (Action 1)");
			};

			//g.EvenNumberGenerated(5);
			g.EvenNumberGeneratedAction(3);

			//g.EvenNumberGenerated = null;
			g.EvenNumberGeneratedAction = null;


			g.EvenNumberGenerated += G_EvenNumberGenerated;

			g.Start();

			System.Threading.Thread.Sleep(TimeSpan.FromMinutes(1));
		}

		static void G_GeneratingNumber(Generator sender)
		{
			var myGenerator = sender as Generator;
			Console.WriteLine(myGenerator.Name + " generará un número");
		}

		static void G_EvenNumberGenerated(object sender, int number)
		{
			if (number % 3 == 0)
			{
				Console.WriteLine("Se generó el número: " + number + "  que también es multiplo de 3, bye bye!");
				g.EvenNumberGenerated -= G_EvenNumberGenerated;
			}
		}
	}
}
