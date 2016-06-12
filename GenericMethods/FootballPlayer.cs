using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    public class FootballPlayer : Athlete
    {
        public string Position { get; set; }
        public int Goals { get; set; }

        public override string ToString()
        {
            return "Hi, I'm " + Name + " and I play football";
        }
    }
}
