using System;

namespace Zoo
{
    public class Poodle : CanisLupusFamiliaris
    {
        public string Variante { get; set; }

        public void MoverOrejas()
        {
            Console.WriteLine("Mueve sus orejas peludas");
        }

        public void Ladrar()
        {
            Console.WriteLine("Bau, bau");
        }
    }
}