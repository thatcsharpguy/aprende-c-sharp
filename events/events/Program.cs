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

			g.GeneratingNumber1 += (sender, e) => 
			{
				var generador = sender as Generator;
				Console.WriteLine(generador.Name + " generará un número (EventHandler)");
			};

			g.EvenNumberGenerated += (sender, number) => 
			{
				Console.WriteLine("Se generó el número par: " + number + " (manejador 1)");
			};

			g.EvenNumberGenerated += G_EvenNumberGenerated;

			g.EvenNumberGeneratedAction += (obj) => 
			{  
				Console.WriteLine("Se generó el número: " + obj + " (Action 1)");
			};

			//g.EvenNumberGenerated(5);
			g.EvenNumberGeneratedAction(3);

			//g.EvenNumberGenerated = null;
			g.EvenNumberGeneratedAction = null;



			g.Start();

			System.Threading.Thread.Sleep(TimeSpan.FromMinutes(1));
		}

		static void G_GeneratingNumber(Generator sender)
		{
			Console.WriteLine(sender.Name + " generará un número");
		}

		static void G_EvenNumberGenerated(object sender, int number)
		{
			Console.Write("Se generó el número par" + number + " (manejador 2)");
			if (number % 7 == 0)
			{
				Console.Write(" que además es múltiplo de 7, bye bye!");
				g.EvenNumberGenerated -= G_EvenNumberGenerated;
			}
			Console.WriteLine();
		}
	}
}
