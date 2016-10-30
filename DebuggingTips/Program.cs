using System;

namespace DebuggingTips
{
	class MainClass
	{
		public static void Main(string[] args)
		{
#if DEBUG
			Console.WriteLine("Solo visible en modo debug, directiva: DEBUG");
#endif

			var tc = new TestClass() { Propiedad1 = "Uno" };
			Console.WriteLine(tc + " // Console.WriteLine ");
			System.Diagnostics.Debug.WriteLine(tc + " // Debug.WriteLine ");
			System.Diagnostics.Debug.WriteLineIf(tc.Propiedad1.Equals("Dos"), tc);

			System.Diagnostics.Debug.Assert(tc.Propiedad1.Equals("Dos"));

			Console.WriteLine("Hello World!");
		}
	}
}
