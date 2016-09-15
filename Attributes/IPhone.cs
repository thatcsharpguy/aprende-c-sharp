using System;
namespace Attributes
{
	public class IPhone
	{
		[ValidCarrier("Vodafone,Telcel,AT&T", MultipleCarriers = true)]
		public string Carrier { get; set; }
	}
}

