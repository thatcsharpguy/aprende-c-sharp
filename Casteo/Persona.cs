using System;
namespace Casteo
{
    public class Persona
    {
        public string Nombre { get; set; }

        public static explicit operator Persona(string nombre)
        {
            return new Persona();    
        }

        public static implicit operator string(Persona p)
        {
            return p.Nombre;
        }
    }
}
