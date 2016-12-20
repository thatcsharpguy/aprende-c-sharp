using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    public class Toy
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public static Bundle operator +(Toy a, Toy b)
        {
            Bundle bundle = new Bundle(2);
            bundle.TryAddToy(a);
            bundle.TryAddToy(b);
            return bundle;
        }

        public static bool operator <(Toy a, Toy b)
        {
            return a.Price < b.Price;
        }

        public static bool operator >(Toy a, Toy b)
        {
            return a.Price > b.Price;
        }

        public static bool operator ==(Toy a, Toy b)
        {
            return a.Price == b.Price;
        }

        public static bool operator !=(Toy a, Toy b)
        {
            return a.Price != b.Price;
        }

        public static bool operator >=(Toy a, Toy b)
        {
            return a == b || a > b;
        }

        public static bool operator <=(Toy a, Toy b)
        {
            return a == b || a < b;
        }
    }
}
