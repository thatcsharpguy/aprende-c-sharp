using System;

namespace Methods
{
	public class Driver
    {
        public Driver(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public string DrivesFor { get; set; }

        public void SetCar(F1Car car)
        {
            DrivesFor = car.Team;
            car.ChangeDriver(this);
        }

        public override bool Equals(object obj)
        {
            var p = obj as Driver;
            if (p != null)
            {
                return Name.Equals(p.Name);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
	}

}

