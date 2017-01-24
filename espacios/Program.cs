using System.Collections.Generic;

class MainClass
{
    static void Main(string[] args)
    {
        OtraColeccion coleccion = new OtraColeccion();
        var lista = new List<OtraColeccion>();

        That.C.Sharp.Guy.Dos dos;
        That.C.Sharp.Guy.Uno uno;
        That.C.Sharp.Guy.Tres tres;

    }
}

namespace That
{
	namespace C
	{
		namespace Sharp
		{
			namespace Guy
			{
				public class Uno { }
			}
		}
	}
}

namespace That.C.Sharp.Guy
{
    public class Dos { }
}

namespace That.C
{
    namespace Sharp.Guy
    {
        public class Tres { }
    }
}

namespace System.Collections.Generic
{
    public class OtraColeccion
    {
    }
}

namespace Spaceship
{
    namespace System
    {
        public class Console
        {
            void TurnOn()
            {
                global::System.Console.WriteLine("La consola ha sido encendida");
            }
        }
    }
}