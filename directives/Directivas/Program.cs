#define HOLA
#define mundo
#define PIZZA
#undef mundo

using System;

namespace Directivas
{
    class Program
    {
        static void Main(string[] args)
        {

#if HOLA && mundo
            Console.WriteLine("Hola mundo");
#elif HOLA
            Console.WriteLine("Hola");
#elif mundo
            Console.WriteLine("Hola");
#else
            Console.WriteLine("...");
#endif

#if (HOLA || mundo) && PIZZA
            Console.WriteLine("Hola o mundo y ¡pizza!");
#endif


            #region Super bloque de código
            Console.WriteLine("Hola");
            #endregion


            Console.Read();

#pragma warning disable 219
            int x = 0;
#pragma warning restore

            return;

#pragma warning disable 162,219
            int zero = 0;
#pragma warning restore

#pragma warning disable
            if (1 != null) ;
#pragma warning restore

        }

        int UnUsed()
        {
            return 0;
        }
    }
}
