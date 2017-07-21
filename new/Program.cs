using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Perritos!");


            Console.WriteLine("Canis genérico:");
            CanisLupusFamiliaris canisGenerico = new CanisLupusFamiliaris();
            canisGenerico.Ladrar();
            canisGenerico.MoverOrejas();
            Console.WriteLine();

            Console.WriteLine("Poolde (Canis):");
            CanisLupusFamiliaris poodleCanis = new Poodle();
            poodleCanis.Ladrar();
            poodleCanis.MoverOrejas();
            Console.WriteLine();

            Console.WriteLine("Poodle:");
            Poodle poodle = new Poodle();
            poodle.Ladrar();
            poodle.MoverOrejas();
            Console.WriteLine();

            Console.WriteLine("Gran danes (Canis):");
            CanisLupusFamiliaris granDanesCanis = new GranDanes();
            granDanesCanis.Ladrar();
            granDanesCanis.MoverOrejas();
            Console.WriteLine();

            Console.WriteLine("Gran danes:");
            GranDanes granDanes = new GranDanes();
            granDanes.Ladrar();
            granDanes.MoverOrejas();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
