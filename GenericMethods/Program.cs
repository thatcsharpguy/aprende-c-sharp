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
            int uno = 1, dos = 2;
            Console.WriteLine(uno + " " + dos);

            Swap<int>(ref uno, ref dos);
            Console.WriteLine(uno + " " + dos);

            Swap(ref uno, ref dos); // Se infiere int como parámetro
            Console.WriteLine(uno + " " + dos);

            float d1 = 10, d2 = 20;
            Console.WriteLine(d1 + " " + d2);

            Swap(ref d1, ref d2); // Se infiere decimal como parámetro
            Console.WriteLine(d1 + " " + d2);

            // Swap(uno, d2); // Error, los tipos no pueden ser inferidos

            // Swap<int>(ref uno, ref d2); // Error, d2 no es entero

            var footballPlayer = new FootballPlayer { Name = "Alex", Height = 183, Weight = 82 };
            Console.WriteLine(footballPlayer);

            // var newBaseballPlayer = ChangeSport(footballPlayer); // Error, los tipos no pueden ser inferidos            var newBaseballPlayer = ChangeSport<BaseballPlayer, FootballPlayer>(footballPlayer);
            Console.WriteLine(newBaseballPlayer);

            Console.Read();
        }


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
    }
}
