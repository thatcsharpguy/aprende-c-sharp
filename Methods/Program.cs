using System;

namespace Methods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var car = F1Car.GetDefaultCar();

            var schumacher = new Driver { Name = "Michael Schumacher" };
            car.ChangeDriver(schumacher);

//            car.StartEngine();
            var started = car.TryStartEngine();
        }
    }
}
