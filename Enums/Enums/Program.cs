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
        FSharp,
        CSharp,
        Swift,
        Java,
        ObjectiveC,
        Assembly,
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
        }
    }
}
