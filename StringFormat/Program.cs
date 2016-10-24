using System;

namespace StringFormat
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(String.Format("Buen día señor {0}", "sol"));
			Console.WriteLine("General formatting:");
			Console.WriteLine(String.Format("{0}, {1} y {2}", "uno", "dos", "tres"));
			Console.WriteLine(String.Format("{1}, {0} y {2}", "uno", "dos", "tres"));
			Console.WriteLine(String.Format("{2}, {0} y {1}", "uno", "dos", "tres"));
			Console.WriteLine();


			Console.WriteLine("Integer formatting");
			int[] enteros = { 1300, -52, 0 };
			FormatArray("{0}", enteros);
			FormatArray("{0:00000}", enteros);
			FormatArray("{0:e}", enteros);
			FormatArray("{0:c}", enteros);
			FormatArray("{0:#.00;Minus 0;Nothing}", enteros);
			Console.WriteLine();


			Console.WriteLine("Hexadecimal:");
			int r = 0, g = 133, b = 20;
			Console.WriteLine(String.Format("Hex: R{0:x}, G{1:x4}, B{2:x2}", r, g, b));
			Console.WriteLine("Hex: {0:x2}{1:x2}{2:x2}", r, g, b);
			Console.WriteLine();


			Console.WriteLine("Real numbers formatting:");
			double[] dobles = { 13000, -52.0d, 0.0, 0.6852871999174d };
			float[] flotantes = { 0.13f, -0.50f, 0.0f, 0.6852871999174f };
			decimal[] decimales = { 0.13m, -0.50m, 0.0m, 0.6852871999174m };
			FormatArray("{0:r}", dobles);
			FormatArray("{0:#,##0.00}", dobles);
			FormatArray("{0:0.0%}", dobles);
			FormatArray("{0:r}", flotantes);
			FormatArray("{0:#,##0.00}", flotantes);
			FormatArray("{0:0.0%}", flotantes);
			FormatArray("{0:r}", decimales);
			FormatArray("{0:#,##0.00}", decimales);
			FormatArray("{0:0.0%}", decimales);
			Console.WriteLine();


			Console.WriteLine("Conditional formatting:");
			FormatArray("{0:#,##0.00;MENOS #,##0.00;—}", decimales);

			Console.WriteLine(String.Format("{0:VERDADERO;FALSO;DESCONOCIDO}", 1)); // Imprime: "VERDADERO"
			Console.WriteLine(String.Format("{0:VERDADERO;FALSO;DESCONOCIDO}", 0));  // Imprime: "DESCONOCIDO"
			Console.WriteLine(String.Format("{0:VERDADERO;FALSO;DESCONOCIDO}", -1));  // Imprime: "FALSO"
			Console.WriteLine();


			Console.WriteLine("DateTime formatting:");
			var now = DateTime.Now;
			MultiFormat(now,
			            "{0:d}",
						"{0:F}",
						"{0:M}",
						"{0:T}",
						"{0:r}");
			Console.WriteLine();


			Console.WriteLine("Custom DateTime formatting:");
			MultiFormat(now,
						"{0:dd/MM/yyyy}",
						"{0:dd-MM-yyyy}",
						"{0:dd MMM yyyy}",
						"{0:dd 'de' MMMM 'de' yy}");
			Console.WriteLine();


			Console.WriteLine("Paddings:");
			FormatArray("Padded numbers: {0,10}", enteros);
			FormatArray("Padded numbers: {0,10:00000}", enteros);
			FormatArray("Izq|{0,10}|{0,-10}|Der", enteros);

			var data = new[]
			{
				new { Dato1 = 0, Dato2="México", Dato3 = DateTime.Now },
				new { Dato1 = 2, Dato2 = "Canadá", Dato3 = DateTime.Now.AddDays(3) },
				new { Dato1 = 10, Dato2 = "Panamá", Dato3 = DateTime.Now.AddDays(-2) },
				new { Dato1 = 0, Dato2 = "Perú", Dato3 = DateTime.Now.AddMonths(-2) }
			};
			foreach (var item in data)
			{
				Console.WriteLine("|{0,10:000}|{1,10}|{2,10:dd-MM}|", item.Dato1, item.Dato2, item.Dato3);
			}
			Console.WriteLine();
		}

		public static void MultiFormat<T>(T value, params string [] formats)
		{
			foreach (var format in formats)
			{
				Console.WriteLine("\t"+format, value);
			}
		}

		public static void FormatArray<T>(string format, params T[] array)
		{ 
			Console.WriteLine("Format " + typeof(T).Name+ ": " + format);
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


