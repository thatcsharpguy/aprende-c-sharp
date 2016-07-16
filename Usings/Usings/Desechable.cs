using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usings
{
    public class Desechable : IDisposable
    {
        public Desechable()
        {
            Console.WriteLine("Hello, Desechable.");
        }

        public void DoSomething()
        {
            Console.WriteLine("Desechable is doing something");
        }

        public void DoSomethingWithException()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Console.WriteLine("Bye bye, Desechable.");
        }
    }
}
