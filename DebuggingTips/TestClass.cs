using System;
using System.Diagnostics;

namespace DebuggingTips
{
	[DebuggerDisplay("Propiedad1: {Propiedad1}")]
	public class TestClass
	{
		public string Propiedad1 { get; set; }
		public int Propiedad2 { get; set; }

		//public override string ToString()
		//{
		//	return string.Format("{0}: {1}", nameof(Propiedad1), Propiedad1);
		//}
	}
}
