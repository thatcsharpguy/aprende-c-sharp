using System;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;

namespace Tuples
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var t = new Tuple<int, string, string>(1, "A", "B");

            // var t1 = new Tuple<int, decimal, object, int, bool, float>(3, 1.5m, new { emoji = ":grin:" }, 5, true, 7.5f);
            var t1 = Tuple.Create(3, 1.5m, new { emoji = ":grin:" }, 5, true, 7.5f);

            Console.WriteLine(t.Item1); // 1 -> int
            Console.WriteLine(t.Item2 + " - " + t.Item3 ); // "A - B" -> string

            // t1.Item4 = 7; // Error, solo lectura

            Console.WriteLine(MegaMetodoArgumentos(10, 3, "MX", 3.1m, true));

            var tuple = Tuple.Create(10, 3, "MX", 3.1m, true);
            Console.WriteLine(MegaMetodoTuple(tuple));

            string color = "3C8A3F";
            int r, g, b;

            SplitColors(color, out r, out g, out b);
            Console.WriteLine("{0} es R:{1} G:{2} B:{3}", color, r, g, b);

            var colors = SplitColors(color);
            Console.WriteLine("{0} es R:{1} G:{2} B:{3}", color, colors.Item1, colors.Item2, colors.Item3);

            var megaTuple = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);
            //Console.WriteLine(miniTuple.Item8); // Item8 no existe, entonces tenemos que usar Rest:
            Console.WriteLine(megaTuple.Rest.Item1);

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
