using System;

namespace Parciales
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            Write(HelloWorldString);
        }
    }

    // Class constants
    partial class Program
    {
        private const string HelloWorldString = "Hola mundo!";
    }
}
