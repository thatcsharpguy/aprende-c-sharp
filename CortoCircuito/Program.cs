using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cortocircuito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ifs");
            if (AlwaysFalse("If 1") && AlwaysTrue("If 1")) ;
            Console.WriteLine();
            if (AlwaysFalse("If 2") & AlwaysTrue("If 2")) ;
            Console.WriteLine();
            if (AlwaysTrue("If 3") || AlwaysTrue("If 3")) ;
            Console.WriteLine();
            if (AlwaysTrue("If 4") | AlwaysTrue("If 4")) ;
            Console.WriteLine();
            if (AlwaysTrue("If 5") | AlwaysTrue("If 5") && (AlwaysFalse("If 5") & AlwaysTrue("If 5")));


            Console.Read();
        }

        public static bool AlwaysTrue(string label = null)
        {
            if (!String.IsNullOrWhiteSpace(label))
                Console.Write(label + ": ");
            Console.WriteLine(true);
            return true;
        }

        public static bool AlwaysFalse(string label = null)
        {
            if(!String.IsNullOrWhiteSpace(label))
                Console.Write(label + ": ");
            Console.WriteLine(false);
            return false;
        }
    }
}
