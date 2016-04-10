using System;

namespace RefOut
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var parametros = new Parametros();
            int a = 100, b = 5;
            Console.WriteLine("Valor de a:" + a + " - Valor de b:" + b);
            parametros.Swap(ref a, ref b);
            Console.WriteLine("Valor de a:" + a + " - Valor de b:" + b);

            int x, y;
//            parametros.Swap(ref x, ref y);

            int resSuma;
            var isResultOk = parametros.SumaMaxima(a, b, 100, out resSuma);

            if (isResultOk)
                Console.WriteLine("La suma excedió el valor máximo");
            else
                Console.WriteLine("El resultado de la suma es " + resSuma);



            string dec = "abcd";
            string dec2 = "555";

            decimal one;
            decimal two;

            if (Decimal.TryParse(dec, out one))
                Console.WriteLine("Convertí " + dec + " en " + one);
            else
                Console.WriteLine(dec  + " no es convertible a decimal");


            if (Decimal.TryParse(dec2, out two))
                Console.WriteLine("Convertí " + dec2 + " en " + two);
            else
                Console.WriteLine(dec  + " no es convertible a decimal");
        }
    }
}
