using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum Hobbies
    {
        Code,
        Tv,
        Sleep
    }

    public enum AssociationFootball
    {
        Soccer = 1,
        Football = Soccer * 2,
        Futbol = Football * 2,
    }

    [Flags]
    public enum ProgrammingLanguages
    {
        FSharp = 1,
        CSharp = 2,
        Swift= 4,
        Java = 8,
        ObjectiveC = 16,
        Assembly = 32
        // Html = 120 // <- Possible but not recommended
    }

    public enum WeirdNumbers : short
    {
        One = 123,
        Two = 431,
        Three = 431,
        Four = 120,
        //Gugol = 100000000000000 // 100000000000000 is not a short
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hobbies:\n");
            var misHobbies = Hobbies.Code;
            Console.WriteLine(misHobbies);
            Console.WriteLine((int)misHobbies);

            misHobbies = (Hobbies)1;
            Console.WriteLine(misHobbies);
            Console.WriteLine((int)misHobbies);


            Console.WriteLine("Programming languages:\n");
            var pl1 = ProgrammingLanguages.CSharp | ProgrammingLanguages.FSharp;
            Console.WriteLine(pl1);
            Console.WriteLine((int)pl1);

            var pl2 = ProgrammingLanguages.Java | ProgrammingLanguages.Swift | ProgrammingLanguages.CSharp;
            Console.WriteLine(pl2);
            Console.WriteLine((int)pl2);


            Console.Read();
        }
    }
}
