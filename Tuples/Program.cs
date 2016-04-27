using System;
using System.Globalization;

namespace Tuples
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(MegaMetodoArgumentos(10,3,"MX",3.1m,true));

            var tuple = Tuple.Create(10, 3, "MX", 3.1m, true);
            Console.WriteLine(MegaMetodoTuple(tuple));

            string color = "3C8A3F";
            int r, g, b;

            SplitColors(color,out r, out g, out b);
            Console.WriteLine(String.Format("{0} es R:{1} G:{2} B:{3}", color, r,g,b));

            var colors = SplitColors(color);
            Console.WriteLine(String.Format("{0} es R:{1} G:{2} B:{3}", color, colors.Item1,colors.Item2,colors.Item3));


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

        private static string MegaMetodoTuple(Tuple<int,int,string,decimal,bool> args)
        {
            // Do something cool:// Do something cool:
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

        private static Tuple<int,int,int> SplitColors(string hex)
        {
            int r = Int32.Parse(hex.Substring(0, 2), NumberStyles.HexNumber);
            int g = Int32.Parse(hex.Substring(2, 2), NumberStyles.HexNumber);
            int b = Int32.Parse(hex.Substring(4, 2), NumberStyles.HexNumber); 

            return Tuple.Create(r, g, b);
        }
    }
}
