using System;
namespace Linq4
{
	public class Persona
	{
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public override string ToString() { return Apellido + ", " + Nombre; }
		public override bool Equals(object o)
		{
			var oth = o as Persona;
			if (oth != null)
				return oth.Apellido.Equals(Apellido);
			return false;
		}

		public override int GetHashCode()
		{
			return Apellido.GetHashCode();
		}
	}
}
