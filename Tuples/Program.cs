using System;
using System.Globalization;
using System.Linq;

namespace Tuples
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(MegaMetodoArgumentos(10, 3, "MX", 3.1m, true));

            var tuple = Tuple.Create(10, 3, "MX", 3.1m, true);

            // tuple.Item1 = 100;

            Console.WriteLine(MegaMetodoTuple(tuple));

            int[] calificaciones = { 10, 6, 9, 7, 8, 10, 6, 6, 7, 10, 9, 6, 9, 8, 8, 9, 9 };
            var analisis = Analyze(calificaciones);

            Console.WriteLine(@"Resultado del análisis:
    Promedio: " + analisis.Item1 + @"
    Mediana " + analisis.Item2 + @"
    Moda: " + analisis.Item3);

            string color = "3C8A3F";
            int r, g, b;

            SplitColors(color, out r, out g, out b);
            Console.WriteLine(String.Format("{0} es R:{1} G:{2} B:{3}", color, r, g, b));

            var c = SplitColors(color);
            Console.WriteLine(String.Format("{0} es R:{1} G:{2} B:{3}", color, c.Item1, c.Item2, c.Item3));

            Console.Read();
        }

        private static Tuple<double, double, int> Analyze(int[] numbers)
        {
            var mean = numbers.Average();

            int numberCount = numbers.Count();
            int halfIndex = numbers.Count() / 2;
            var sortedNumbers = numbers.OrderBy(n => n);
            double median;
            if ((numberCount % 2) == 0)
            {
                median = ((sortedNumbers.ElementAt(halfIndex) + sortedNumbers.ElementAt((halfIndex - 1))) / 2);
            }
            else {
                median = sortedNumbers.ElementAt(halfIndex);
            }

            var mode = numbers.GroupBy(n => n)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key).FirstOrDefault();

            return Tuple.Create(mean, median, mode);
        }

        private static string MegaMetodoArgumentos(int studentId, int classroomId, string type, decimal sum, bool active)
        {
            // Do something cool:
            var mix = studentId ^ classroomId;
            var mix1 = mix * sum;
            if (active)
            {
                mix1 *= -1;
            }
            return mix1 + type;
        }

        private static string MegaMetodoTuple(Tuple<int, int, string, decimal, bool> args)
        {
            // Do something cool:
            var mix = args.Item1 ^ args.Item2;
            var mix1 = mix * args.Item4;
            if (args.Item5)
            {
                mix1 *= -1;
            }
            return mix1 + args.Item3;
        }

        private static void SplitColors(string hex, out int r, out int g, out int b)
        {
            r = Int32.Parse(hex.Substring(0, 2), NumberStyles.HexNumber);
            g = Int32.Parse(hex.Substring(2, 2), NumberStyles.HexNumber);
            b = Int32.Parse(hex.Substring(4, 2), NumberStyles.HexNumber);
        }

        private static Tuple<int, int, int> SplitColors(string hex)
        {
            int r = Int32.Parse(hex.Substring(0, 2), NumberStyles.HexNumber);
            int g = Int32.Parse(hex.Substring(2, 2), NumberStyles.HexNumber);
            int b = Int32.Parse(hex.Substring(4, 2), NumberStyles.HexNumber);

            return Tuple.Create(r, g, b);
        }
    }
}
