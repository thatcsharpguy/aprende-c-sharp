using System;
namespace Casteo
{
    public class Metro
    {
        public decimal Valor
        {
            get;
            private set;
        }

        public Metro(decimal valor)
        {
            Valor = valor;
        }

        public static implicit operator Metro(decimal d)
        {
            return new Metro(d);
        }

        public static explicit operator decimal(Metro m)
        {
            return m.Valor;
        }

        public static explicit operator Metro(Yarda m)
        {
            var metro = new Metro(m.Valor / 0.9144m);
            return metro;
        }

        public override string ToString()
        {
            return $"{Valor:0.000} metro(s)";
        }
    }

    public class Yarda
    {
        public decimal Valor
        {
            get;
            set;
        }

        public Yarda(decimal valor)
        {
            Valor = valor;
        }

        public static implicit operator Yarda(decimal d)
        {
            return new Yarda(d);
        }

        public static explicit operator decimal(Yarda m)
        {
            return m.Valor;
        }

        public static explicit operator Yarda(Metro m)
        {
            var yarda = new Yarda(m.Valor * 0.9144m);
            return yarda;
        }

        public override string ToString()
        {
            return $"{Valor:0.000} yarda(s)";
        }

    }
}
