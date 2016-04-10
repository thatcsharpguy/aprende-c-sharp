using System;

namespace Methods
{
	public class Pilot
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            var p = obj as Pilot;
            if (p != null)
            {
                return Name.Equals(p.Name);
            }
            return false;
        }
	}

}

