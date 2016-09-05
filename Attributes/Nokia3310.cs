using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Attributes
{
	[ObsoleteAttribute]
	public class Nokia3310
	{
		[RangeAttribute(0,9990.99)]
		public double Balance { get; set; }
		
		[Obsolete]
		public void Call(string number, [CallerMemberName]string whoIsCalling = null)
		{
			Console.WriteLine(whoIsCalling + " is calling " + number);
		}
	}
}

