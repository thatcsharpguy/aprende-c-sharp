
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    public class Team<T> where T : Athlete
    {
        public int MaxPlayersOnField { get; private set; }
        public string CoachName { get; set; }
        public T[] Members { get; set; }

        public Team(int maxMembers, int maxPlayersOnField)
        {
            Members = new T[maxMembers];
            MaxPlayersOnField = maxPlayersOnField;
        }
    }
}
