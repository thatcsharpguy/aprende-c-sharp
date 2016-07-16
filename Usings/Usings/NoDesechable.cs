using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usings
{
    public class NoDesechable
    {
        public NoDesechable()
        {
            Console.WriteLine("Hello, NoDesechable.");
        }

        public void DoSomethingWithException()
        {
            throw new NotImplementedException();
        }

        public void DoSomething()
        {
            Console.WriteLine("NoDesechable is doing something");
        }
    }
}
