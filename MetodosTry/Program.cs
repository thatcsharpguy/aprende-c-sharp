using System;

namespace MetodosTry
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var values = new[]
            {
                "1",
                "-",
                null,
                " ",
                "2147483648",
                "2147483647",
                "0.1"
            };

            foreach (var value in values)
            {
                var intValue = -1;
                try
                {
                    intValue = int.Parse(value);
                    Console.WriteLine("Cadena \"" + value + "\" resultado: " + intValue);
                }
                catch
                {
                    Console.WriteLine("Cadena \"" + value + "\" resultado: " + intValue + " (Ocurrió un error)");
                }
            }
            Console.WriteLine();

            foreach (var value in values)
            {
                var intValue = -1;
                try
                {
                    intValue = int.Parse(value);
                    Console.WriteLine("Cadena \"" + value + "\" resultado: " + intValue);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Cadena \"" + value + "\" resultado: " + intValue + " (Error de formato)");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Cadena \"" + value + "\" resultado: " + intValue + " (El valor es null)");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Cadena \"" + value + "\" resultado: " + intValue +
                                      " (El valor es más grande que un entero)");
                }
            }
            Console.WriteLine();

            foreach (var value in values)
            {
                int intValue;
                if (int.TryParse(value, out intValue))
                    Console.WriteLine("Cadena \"" + value + "\" resultado: " + intValue);
                else
                    Console.WriteLine("Cadena \"" + value + "\" resultado: " + intValue + " (Ocurrió un error)");
            }

            Console.ReadLine();
        }
    }
}