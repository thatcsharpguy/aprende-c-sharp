using System;
using System.Linq;

namespace Indizadores
{
	public class Toy
	{
		public string Name { get; set; }
		public double Price { get; set; }

		public static bool operator <(Toy a, Toy b)
		{
			return a.Price < b.Price;
		}

		public static bool operator >(Toy a, Toy b)
		{
			return a.Price > b.Price;
		}

		//public static bool operator <(Toy a, double price)
		//{
		//	return a.Price < price;
		//}

		//public static bool operator >(Toy a, double price)
		//{
		//	return a.Price > price;
		//}

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

		public static Bundle operator +(Toy a, Toy b)
		{
			Bundle bundle = new Bundle(2);
			bundle.TryAddToy(a);
			bundle.TryAddToy(b);
			return bundle;
		}
	}
}
