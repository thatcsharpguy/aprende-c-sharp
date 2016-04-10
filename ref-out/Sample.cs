using System;

namespace RefOut
{
    public class Parametros
    {
        public void Swap(ref int a, ref int b)
        {
            int m = a;
            a = b;
            b = m;
        }

        public bool SumaMaxima(int a, int b, int max, out int resultado)
        {
            resultado = a + b;
            if (resultado >= max)
            {
                resultado = max;
                return true;
            }
            return false;
        }

        public string WeirdMethod(ref int a, ref int b, out int s, out int r)
        {
            s = a + b;
            r = a - b;
            return a.ToString() + " " + b.ToString();
        }
    }
}

