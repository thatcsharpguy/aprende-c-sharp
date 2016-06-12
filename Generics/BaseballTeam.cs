using System;
namespace Generics
{
	public class BaseballTeam
	{
		public string CoachName { get; set; }
		public BaseballPlayer[] Members { get; set; }

		public BaseballTeam(int maxMembers)
		{
			Members = new BaseballPlayer[maxMembers];
		}
	}
}