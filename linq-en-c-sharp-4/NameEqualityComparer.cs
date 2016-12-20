using System;
using System.Collections.Generic;

namespace Linq4
{
	public class NameEqualityComparer : IEqualityComparer<Persona>
	{
		public bool Equals(Persona x, Persona y) => x.Nombre.Equals(y.Nombre);

		public int GetHashCode(Persona obj) => obj.Nombre.GetHashCode();
	}
}
