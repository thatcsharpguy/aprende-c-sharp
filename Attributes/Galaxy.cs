using System;
namespace Attributes
{
	public class Galaxy
	{
		[ValidCarrier("Vodafone,Movistar,Sprint")]
		public string Carrier { get; set; }
	}
}

