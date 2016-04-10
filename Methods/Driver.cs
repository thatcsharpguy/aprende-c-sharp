using System;

namespace Methods
{
	public class Driver
    {
        public string Name { get; set; }

        public string DrivesFor { get; set; }

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

