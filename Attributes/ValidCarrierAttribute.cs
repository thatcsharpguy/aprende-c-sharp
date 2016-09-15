using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Attributes
{
	[AttributeUsage(AttributeTargets.Property)]
	public class ValidCarrierAttribute : ValidationAttribute
	{
		private string[] _validCarriers;

		//			   Positional parameter vvvvvvvvvvvvv
		public ValidCarrierAttribute(string validCarriers)
		{
			_validCarriers = validCarriers.Split(',');
		}

		// Named parameter 
		//          vvvvvvvvvvvvvvvv
		public bool MultipleCarriers { get; set; }

		public override bool IsValid(object value)
		{
			var carriers = (value as string)?.Split(',');
			if (carriers == null || !carriers.Any())
				return false;

			var coincidences = carriers.Intersect(_validCarriers);

			if (coincidences.Count() > 1 && MultipleCarriers)
			{
				return true;
			}
			else if (coincidences.Count() > 1 && !MultipleCarriers)
			{
				return false;
			}
			else if (coincidences.Any())
			{
				return true;
			}

			return false;
		}
	}
}

