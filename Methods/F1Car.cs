using System;

namespace Methods
{
    public class F1Car
    {
        public F1Car()
        {
        }

        public bool IsRunning { get; private set; }

        internal static F1Car GetDefaultCar()
        {
            return new F1Car();
        }

        private Pilot _currentPilot;
        public void ChangeDriver(Pilot newPilot)
        {
            if (!newPilot.Equals(_currentPilot))
            {
                _currentPilot = newPilot;
            }
        }

        void StartEngine() 
        {
            IsRunning = true;
        }

        public bool TryStartEngine()
        {
            if (_currentPilot == null)
            {
                return false;
            }
            StartEngine();
            return true;
        }

    }
}

