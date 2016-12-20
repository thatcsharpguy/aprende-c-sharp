using System;
using System.Collections;
using System.Collections.Generic;

namespace Yield
{

	public class NotSoRandom : IEnumerable<int>
	{
		Random r = new Random();

		public IEnumerator<int> GetEnumerator()
		{
			while (true)
			{
				Console.Write("G ");
				yield return r.Next();
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			while (true)
			{
				yield return r.Next();
			}
		}
	}
}
