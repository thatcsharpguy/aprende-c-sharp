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
            CanisLupusFamiliaris canis = new CanisLupusFamiliaris();
            canis.Ladrar();
            canis.MoverOrejas();
            Console.WriteLine();

            Console.WriteLine("Chihuahua (Canis):");
            CanisLupusFamiliaris chihuahuaCanis = new Chihuahua();
            chihuahuaCanis.Ladrar();
            chihuahuaCanis.MoverOrejas();
            Console.WriteLine();

            Console.WriteLine("Chihuahua:");
            Chihuahua chihuahua = new Chihuahua();
            chihuahua.Ladrar();
            chihuahua.MoverOrejas();
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
