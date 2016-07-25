using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
	public enum TextAlign
	{
		Right,
		Left,
		Center,
		Justify
	}

	public enum OperatingSystems
	{
		Windows = 1,    // 000001
		Mac = 2,        // 000010
		Linux = 4,      // 000100
		Other = 8       // 001000
	}

	public enum AssociationFootball
	{
		Soccer = 1,
		Football = Soccer * 2,
		Futbol = Football * 2,
	}

	public enum Months : short
	{
		January = 123,
		February = 431,
		March = 432,
		April = 120,
		// Jupiter = 100000000000000 // 100000000000000 is not a short
	}

	[Flags]
	public enum DaysOfWeek 
	{
		Sun = 1, Mon = 2, Tue = 4, 
		Wed = 8, Thu = 16, Fri = 32, 
		Sat = 64
	}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Text Align:\n");
			var textAlignment = TextAlign.Center;
            Console.WriteLine(textAlignment);
            Console.WriteLine((int)textAlignment);

            textAlignment = (TextAlign)1;
            Console.WriteLine(textAlignment);
            Console.WriteLine((int)textAlignment);

			switch (textAlignment)
			{
				case TextAlign.Center:
					Console.WriteLine("Texto centrado");
				break;
			}

            Console.WriteLine("Operating systems:\n");
            var pl1 = OperatingSystems.Mac | OperatingSystems.Windows;
            Console.WriteLine(pl1);
            Console.WriteLine((int)pl1);

			if (pl1.HasFlag(OperatingSystems.Mac))
			{
				Console.WriteLine("User knows Mac"); // <-- This will execute
			}

            var pl2 = OperatingSystems.Other | OperatingSystems.Linux | OperatingSystems.Mac;
            Console.WriteLine(pl2);
            Console.WriteLine((int)pl2);

			Console.WriteLine("Days of week:\n");

			var alarmGoesOffOn = DaysOfWeek.Mon | DaysOfWeek.Wed | DaysOfWeek.Fri;
			Console.WriteLine("Alarm goes off on: " + alarmGoesOffOn);


			Console.Read();
        }
    }
}
