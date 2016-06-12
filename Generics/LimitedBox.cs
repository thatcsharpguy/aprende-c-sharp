using System;
namespace Generics
{
	public class LimitedBox<T> where T : struct
	{
	}

	public class LimitedBox<X0,X1> 
		where X0 : struct
		where X1 : IEquatable<X1>
	{
	}

	public class LimitedBox<T, U, V>
		where T : struct
		where U : IEquatable<U>
		where V : new()
	{
	}
}

