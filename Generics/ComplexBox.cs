using System;
namespace Generics
{
	public class ComplexBox<T, Content1, Content2>
	{
		public Content1 C1 { get; set; }
		public Content2 C2 { get; set; }
		public T Item { get; set; }

		public ComplexBox(Content1 c1, Content2 c2)
		{
			C1 = c1;
			C2 = c2;
		}
	}
}

