using System;
using System.Linq;

namespace Params
{
    class Program
    {
        public static void Main(string[] args)
        {
            Metodo1Arrays(null);
            Metodo1Params();

            bool cierto = true;
            // Metodo1Arrays(cierto); // Nope, necesita un arreglo
            Metodo1Arrays(new bool[] { cierto });
            Metodo1Params(cierto);

            Metodo1Arrays(new []{ cierto, false, true, cierto });
            Metodo1Params(cierto, false, true, cierto);


            var array = new decimal[] { 1, 2, 3 };
            Metodo2Arrays(1, 'A', array);
            Metodo2Params(1, 'B', array);

            Metodo2Arrays(1, 'C', new decimal []{ });
            Metodo2Params(1, 'D');

            Metodo2Arrays(1, 'E', new []{ 2.1m, 13m, 15m });
            Metodo2Params(1, 'E', 2.1m, 13m, 15m);


            decimal[] alumno1 = new decimal [] { 10m, 9.2m, 7m, 3.5m, 10m };
            var alumno2 = new []{ 8.5m, 9.3m, 8.6m, 9.9m, 10m };

            PromediaCalificacionesArray(new []{ alumno1, alumno2 });
            PromediaCalificacionesParams(alumno1, alumno2);

        }



        // public static void Metodo1Params(params char a) // Invalido, debe ser un arreglo
        // {
        // }

        public static void Metodo1Params(params bool[] a)
        {
            Console.WriteLine("M1Params recibió " + a.Length + " booleanos");
        }

        public static void Metodo1Arrays(bool[] a)
        {
            if (a == null)
            {
                a = new bool[]{ };
            }
            Console.WriteLine("M1Arrays recibió " + a.Length + " booleanos");
        }

        public static void Metodo2Params(int a, char b, params decimal[] c)
        {
            Console.WriteLine("Metodo3Params: " + c.Length);
        }

        public static void Metodo2Arrays(int a, char b, decimal[] c)
        {
            Console.WriteLine("Metodo3Array: " + c.Length);
        }


        // public static void Metodo3Params(int a, params decimal[] b, char c) // Maaaal, params debe ser el último elemento en la lista de argumentos
        // {
        //     Console.WriteLine("Metodo3Params: " + b.Length);
        // }

        public static void Metodo3Arrays(int a, decimal[] b, char c)
        {
            
        }

        public static void PromediaCalificacionesArray(decimal[][] calificaciones)
        {
            for (int i = 0; i < calificaciones.Length; i++)
            {
//                int calificacionesReportadas = calificaciones[i].Length;            
//                decimal promedio = 0m;
//                for (int j = 0; j < calificaciones[i].Length; j++)
//                {
//                    promedio += calificaciones[i][j];
//                }
//                promedio = promedio / calificacionesReportadas;
//                Mejor usemos LINQ:
                decimal promedio = calificaciones[i].Average();
                Console.WriteLine("(Arrays) Calificación alumno " + i + ": " + promedio);
            }
        }

        public static void PromediaCalificacionesParams(params decimal[][] calificaciones)
        {
            for (int i = 0; i < calificaciones.Length; i++)
            {
                decimal promedio = calificaciones[i].Average();
                Console.WriteLine("(Params) Calificación alumno " + i + ": " + promedio);
            }
        }
    }
}
