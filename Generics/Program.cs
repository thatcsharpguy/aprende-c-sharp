using System;

namespace Generics
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var cajaDeEntero = new Box<int>(5);
			var cajaDeString = new Box<string>("Hola mundo");

			Console.WriteLine(cajaDeEntero.Content); // 5
			Console.WriteLine(cajaDeString.Content); // Hola mundo

			var cajaDeCajas = new Box<Box<string>>(cajaDeString);
			Console.WriteLine(cajaDeCajas); // [Box: Content=[Box: Content=Hola mundo]]

			var cajota = new ComplexBox<double, decimal, float>(1, 2)
			{
				Item = 3
			};

			// var limitado = new LimitedBox<string>(); // Error, string no es struct
			var limitado = new LimitedBox<DateTime>(); // OK, DateTime es struct

			// var limitado1 = new LimitedBox<DateTime, Box<string>>(); // Error, Box<string> no implementa IEquatable
			var limitado1= new LimitedBox<DateTime, string>(); // OK, string sí implementa IEquatable

			// var limitado2 = new LimitedBox<DateTime, string, string>(); // Error, el tipo string no tiene un constructor sin parámetros
			var limitado2 = new LimitedBox<DateTime, string, MainClass>(); // OK, MainClass sí tiene un constructor sin parámetros


			// Ejemplo:

			// var vitesse = new FootballTeam(18); 
			var vitesse = new Team<FootballPlayer>(18);
			vitesse.Members[0] = new FootballPlayer { Name = "Alex Renato Ibarra Mina" };
			       
			// var losAngeles = new BaseballTeam(25);
			var losAngeles = new Team<BaseballPlayer>(25);
			losAngeles.Members[0] = new BaseballPlayer { Name = "Julio César Urías" };

			// var equipoDeEnteros = new Team<int>(10); // Error. Ni int
			// var otroEquipo = new Team<object>(1233); // ni object son (o derivan de) Athlete
		}
	}


}
