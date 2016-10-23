using System;

namespace StringFormat
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Integer formatting");
			int[] enteros = { 1300, -52, 0 };
			FormatArray("{0}", enteros);
			FormatArray("{0:00000}", enteros);
			FormatArray("{0:e}", enteros);
			FormatArray("{0:c}", enteros);
			FormatArray("{0:#.00;Minus 0;Nothing}", enteros);

			Console.WriteLine("Double formatting");
			double[] dobles = { 13000, -52.0, 0.0 };
			FormatArray("{0:r}", dobles);
			FormatArray("{0:#,##0.00}", dobles);
			FormatArray("{0:#,##0.00;;—}", dobles);
			FormatArray("{0:0%}", dobles);
		}

		public static void FormatArray<T>(string format, T[] array)
		{ 
			Console.WriteLine("Format: " + format);
			foreach (var item in array)
			{
				try
				{
					Console.WriteLine("\t" + String.Format(format, item));
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error de formato {0}",typeof(T).Name);
				}
			}
		}
	}
}
