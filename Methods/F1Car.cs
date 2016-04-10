using System;

namespace Methods
{
    public class F1Car
    {
        public F1Car(string team)
        {
            Team = team;
        }

        public string Team { get; private set; }

        public bool IsRunning { get; private set; }

        internal static F1Car GetDefaultCar()
        {
            return new F1Car("Default");
        }
            
        public Driver Driver 
        { 
            get {return _currentDriver;}
        }

        private Driver _currentDriver;
        public void ChangeDriver(Driver newDriver)
        {
            if (!newDriver.Equals(_currentDriver))
            {
                _currentDriver = newDriver;
            }
        }

        void StartEngine() 
        {
            IsRunning = true;
        }

        public bool TryStartEngine()
        {
            if (_currentDriver == null)
            {
                return false;
            }
            StartEngine();
            return true;
        }

    }
}

