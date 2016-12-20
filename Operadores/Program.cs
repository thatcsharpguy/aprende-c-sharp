using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            var buzzLightyear = new Toy { Name = "Buzz", Price = 20 };
            var woody = new Toy { Name = "Woody", Price = 20 };
            var dory = new Toy { Name = "Dory", Price = 15 };
            var marlin = new Toy { Name = "Marlin", Price = 15 };
            var nemo = new Toy { Name = "Nemo", Price = 15 };
            var mikey = new Toy { Name = "Michelangelo", Price = 25 };
            var leo = new Toy { Name = "Leonardo", Price = 25 };
            var donny = new Toy { Name = "Donatello", Price = 25 };
            var raph = new Toy { Name = "Raphael", Price = 25 };
            var splinter = new Toy { Name = "Master Splinter", Price = 30 };

            Console.WriteLine(buzzLightyear.Name + "==" + woody.Name + " = " + (buzzLightyear == woody));
            Console.WriteLine(dory.Name + "==" + woody.Name + ": " + (dory == woody));
            Console.WriteLine(dory.Name + "==" + woody.Name + ": " + (dory == woody));
            Console.WriteLine(dory.Name + ">" + woody.Name + ": " + (dory > woody));
            Console.WriteLine(dory.Name + "<" + woody.Name + ": " + (dory < woody));
            Console.WriteLine(splinter.Name + ">=" + woody.Name + ": " + (splinter >= woody));
            Console.WriteLine(leo.Name + "<=" + raph.Name + ": " + (leo <= raph));
            Console.WriteLine();


            var toyStoryBundle = buzzLightyear + woody;
            Console.WriteLine(toyStoryBundle);

            //var findingNemoBundle = dory + marlin + nemo;
            var findingNemoBundle = dory + marlin + nemo;
            // var findingNemoBundle = (dory + marlin) + nemo; // <- Same as
            Console.WriteLine(findingNemoBundle);
            //var findingNemoBundle

            var disneyBundle = findingNemoBundle + toyStoryBundle;
            Console.WriteLine(disneyBundle);
            Console.WriteLine();


            var tortugasNinja = new Bundle(4);
            Console.WriteLine(tortugasNinja);

            tortugasNinja = tortugasNinja + mikey;
            Console.WriteLine(tortugasNinja);

            tortugasNinja = tortugasNinja + leo;
            tortugasNinja = tortugasNinja + donny;
            Console.WriteLine(tortugasNinja);

            tortugasNinja += raph;
            Console.WriteLine(tortugasNinja);

            try
            {
                tortugasNinja += splinter;
                Console.WriteLine(tortugasNinja);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine("Oops: " + ioe.Message);
            }

            Console.Read();
        }
    }
}
