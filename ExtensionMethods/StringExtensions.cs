using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensiones
{
    static class StringExtensions
    {
        public static int ToInt(this string str)
        {
            int i;
            Int32.TryParse(str, out i);
            return i;
        }

        public static string Mountain(this string str)
        {
            if (String.IsNullOrEmpty(str)) return "";
            var array = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                try
                {
                    var isUppercase = str[i].IsUppercase();
                    var shouldBeUppercase = i % 2 == 0;

                    if (shouldBeUppercase && !isUppercase)
                        array[i] = str[i].Flip();
                    else if (!shouldBeUppercase && isUppercase)
                        array[i] = str[i].Flip();
                    else
                        array[i] = str[i];
                }
                catch
                {
                    array[i] = str[i];
                }
            }
            return new String(array);
        }

        public static string Flip(this string str)
        {
            if (String.IsNullOrEmpty(str)) return "";
            var array = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                array[i] = str[i].Flip();
            }
            return new String(array);
        }
    }

    public static class CharExtensions
    {
        const int UppercaseLowerBound = 65;
        const int UppercaseUpperBound = 90;
        const int LowercaseLowerBound = 97;
        const int LowercaseUpperBound = 122;

        public static bool IsUppercase(this char c)
        {
            if (UppercaseLowerBound <= c && c <= UppercaseUpperBound)
                return true;
            else if (LowercaseLowerBound <= c && c <= LowercaseUpperBound)
                return false;
            throw new ArgumentException(String.Format("{0} is not a letter", c));
        }

        const int Offset = 32;
        public static char Flip(this char c)
        {
            try
            {
                return (char)(IsUppercase(c) ? c + Offset : c - Offset);
            }
            catch
            {
                return c;
            }
        }
    }
}
