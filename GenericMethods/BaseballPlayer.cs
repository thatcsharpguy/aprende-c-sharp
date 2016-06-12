using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    public class BaseballPlayer :Athlete
    {
        public string Position { get; set; }
        public int GamesStarted { get; set; }

        public override string ToString()
        {
            return "Hi, I'm " + Name + " and I play baseball";
        }
    }
}
