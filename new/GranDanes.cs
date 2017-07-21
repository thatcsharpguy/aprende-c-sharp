using System;

namespace Zoo
{
    public class GranDanes : CanisLupusFamiliaris
    {
        public new void MoverOrejas()
        {
            Console.WriteLine("Mueve sus orejas gigantezcas");
        }

        public override void Ladrar()
        {
            Console.WriteLine("Woof, woof");
        }
    }
}