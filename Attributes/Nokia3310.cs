using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Attributes
{
	[ObsoleteAttribute("Esta clase es obsoleta, prueba con iPhone 6 o Galaxy S6")]
	public class Nokia3310
	{
		[RangeAttribute(0.0,9990.99, ErrorMessage = "Wrong balance, must be between {1} and {2}")]
		public double Balance { get; set; }
		
		[Obsolete]
		public void Call(string number, [CallerMemberName]string whoIsCalling = null)
		{
			Console.WriteLine(whoIsCalling + " is calling " + number);
		}
	}
}

