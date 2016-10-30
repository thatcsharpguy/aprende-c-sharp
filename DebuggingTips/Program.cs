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

			var tc = new TestClass() { Propiedad1 = "Uno, dos y tres" };
			Console.WriteLine(tc);

			Console.WriteLine("Hello World!");
		}
	}
}
