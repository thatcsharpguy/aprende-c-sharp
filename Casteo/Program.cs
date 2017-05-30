using System;

namespace Casteo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Persona p1 = new Persona { Nombre = "Antonio" };
            Persona p2 = (Persona)"Antonio";
            string nombreP2 = p2;

            var metro1 = new Metro(5);
            var yarda1 = new Yarda(5);

            Console.WriteLine(metro1);
            Console.WriteLine(yarda1);


            Metro metro2 = 10;
            Yarda yarda2 = 10;

            Console.WriteLine(metro2);
            Console.WriteLine(yarda2);

            Yarda yarda3 = (Yarda)metro2;
            Metro metro3 = (Metro)yarda2;

            Console.WriteLine(metro3);
            Console.WriteLine(yarda3);

            Metro metro4 = (Metro)yarda3;
            Yarda yarda4 = (Yarda)metro3;

            Console.WriteLine(metro4);
            Console.WriteLine(yarda4);
        }
    }
}
