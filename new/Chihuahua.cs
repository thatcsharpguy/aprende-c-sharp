using System;

namespace Zoo
{
    public class Chihuahua : CanisLupusFamiliaris
    {
        public event EventHandler E;

        public void MoverOrejas()
        {
            Console.WriteLine("Mueve sus orejitas");
        }

        public void Ladrar()
        {
            Console.WriteLine("guau, guau");
        }
    }
}