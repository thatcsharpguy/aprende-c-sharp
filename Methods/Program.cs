using System;

namespace Methods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var car = F1Car.GetDefaultCar();

            var schumacher = new Pilot { Name = "Michael Schumacher" };
            car.ChangeDriver(schumacher);

            car.TryStartEngine();
        }
    }
}
