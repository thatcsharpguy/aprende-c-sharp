using System;

namespace Zoo
{
    public class CanisLupusFamiliaris : CanisLupus
    {

        public void MoverOrejas()
        {
            Console.WriteLine("Error: sin informaci¨®n");
        }

        public virtual void Ladrar()
        {
            Console.WriteLine("Ladrido gen¨¦rico");
        }
    }
}