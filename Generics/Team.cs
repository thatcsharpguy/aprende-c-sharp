using System;
namespace Generics
{
	public class Team<T> where T : Athlete
	{
		public string CoachName { get; set; }
		public T[] Members { get; set; }

		public Team(int maxMembers)
		{
			Members = new T[maxMembers];
		}
	}
}

