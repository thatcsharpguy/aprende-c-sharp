using System;

namespace Methods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var car = F1Car.GetDefaultCar();

            var schumacher = new Driver("Michael Schumacher" );
            car.ChangeDriver(schumacher);

//            car.StartEngine();
            var started = car.TryStartEngine();

            var toroRossoCar = new F1Car("Toro Rosso");
            var verstappen = new Driver("Max Emilian Verstappen");
            verstappen.SetCar(toroRossoCar);
        }
    }
}
