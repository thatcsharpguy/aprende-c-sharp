using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Resxs
{
    class Program
    {
        public static Tuple<string, string>[] Languages = new Tuple < string, string>[]
        {
            Tuple.Create("es-MX", "Español - Mexico"),
            Tuple.Create("it-IT", "Italiano - Italia"),
            Tuple.Create("en-GB", "English - United Kingdom"),
            Tuple.Create("ru-RU", "Russian - Russia"),
            Tuple.Create("en-US", "English - United States")
        };

        static void Main(string[] args)
        {
            var currentThread = Thread.CurrentThread;
            int currentLanguage = 0;
            do
            {
                var language = new CultureInfo(Languages[currentLanguage].Item1);
                Thread.CurrentThread.CurrentUICulture = language;
                Console.WriteLine(String.Format(Resources.Strings.CurrentLanguage, currentThread.CurrentUICulture.ToString()));
                Console.WriteLine(Resources.Strings.Hello);
            } while ((currentLanguage = ChangeLanguage()) >= 0);
        }

        private static int ChangeLanguage()
        {
            Console.WriteLine(new String('=',10));
            Console.WriteLine(Resources.Strings.ChangeLanguage);
            for (int i = 0; i < Languages.Count(); i++)
            {
                Console.WriteLine("\t" + Languages[i].Item2 + " " + i);
            }
            Console.WriteLine("\t" + Resources.Strings.Exit + ": -1");

            return Int32.Parse(Console.ReadLine());
        }
    }
}
