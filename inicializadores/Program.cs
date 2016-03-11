using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inicializadores
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        public Person(string name, Person dad, Person mom)
        {
            Name = name;
            Dad = dad;
            Mom = mom;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person Dad { get; set; }
        public Person Mom { get; set; }
        public List<Person> Friends { get; set; }
    }
}
