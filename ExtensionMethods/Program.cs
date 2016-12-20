using System;
using System.Linq;
using Extensiones;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var secuencia = new int[] { 1, 2, 3, 4, 5, 6 };
            var resultado = Enumerable.Take(Enumerable.Where(secuencia, i => i % 2 == 0), 1);
            // var resultado = secuencia.Where(i => i % 2 == 0).Take(1);

            Console.WriteLine("Console.WriteLine();".Mountain());
            Console.WriteLine(StringExtensions.Mountain("Console.WriteLine();"));

            string n = null;
            Console.WriteLine("null = " + n.Mountain());
            Console.Read();

        }
    }
}
