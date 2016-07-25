using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
			WriteType<int>();
			WriteType<Program>();

			var dflt = GetDefault<int>(10);
			var dflt2 = GetDefault(4.0); // Se infiere que es double a partir del argumento pasado al método
			// int dflt3 = GetDefault(DateTime.Now); // Error, DateTime no se puede convertir a int implícitamente

            int uno = 1, dos = 2;
            Console.WriteLine(uno + " " + dos);

            Swap<int>(ref uno, ref dos);
            Console.WriteLine(uno + " " + dos);

            Swap(ref uno, ref dos); // Se infiere int como parámetro de tipo
            Console.WriteLine(uno + " " + dos);

            float d1 = 10, d2 = 20;
            Console.WriteLine(d1 + " " + d2);

            Swap(ref d1, ref d2); // Se infiere float como parámetro
            Console.WriteLine(d1 + " " + d2);

            // Swap(uno, d2); // Error, los tipos no pueden ser inferidos

            // Swap<int>(ref uno, ref d2); // Error, d2 no es entero

            var footballPlayer = new FootballPlayer { Name = "Alex", Height = 183, Weight = 82 };
            Console.WriteLine(footballPlayer);

            // var newBaseballPlayer = ChangeSport(footballPlayer); // Error, los tipos no pueden ser inferidos
            var newBaseballPlayer = ChangeSport<BaseballPlayer, FootballPlayer>(footballPlayer);
            Console.WriteLine(newBaseballPlayer);

            Console.Read();
        }

		static void WriteType<T>()
		{
			var a = typeof(T);
			Console.WriteLine(a.Name);
		}

		static T GetDefault<T>(T useless)
		{
			return default(T);
		}

        static void Swap<T>(ref T a, ref T b)
        {
            T t = a;
            a = b;
            b = t;
        }

		//static void Swap(ref decimal a, ref decimal b)
		//{
		//    decimal t = a;
		//    a = b;
		//    b = t;
		//}

		//static void Swap(ref int a, ref int b)
		//{
		//    int t = a;
		//    a = b;
		//    b = t;
		//}

		static T ChangeSport<T, W>(W toCast)
			where T : Athlete, new()
			where W : Athlete
		{
			var a = new T()
			{
				Height = toCast.Height,
				Weight = toCast.Weight,
				Name = toCast.Name
			};
			return a;
		}
    }
}
