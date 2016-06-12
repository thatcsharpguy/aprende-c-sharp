using System;
namespace Generics
{
	public class FootballTeam
	{
		public string CoachName { get; set; }
		public FootballPlayer[] Members { get; set; }

		public FootballTeam(int maxMembers)
		{
			Members = new FootballPlayer[maxMembers];
		}
	}
}