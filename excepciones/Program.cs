using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /// ### Por razones evidentes, mucho del 
            /// código de este demo está comentado ###

            //throw new Exception("Hey, soy el mensaje de la excepción");

            //var ex = new FormatException("Hey, soy una excepción guardada en una variable");
            //throw ex;

            //var adulto = new Adulto();
            //adulto.NumeroGatos = 10;

            var adulto2 = new Adulto();
            try
            {
                // Intentamos algo peligroso:
                adulto2.NumeroGatos = Int32.MaxValue;
            }
            catch (TienesMuchosGatosException te)
            {
                // Manejamos la excepción relacionada con los gatos:
                Console.WriteLine("Ooops, no puedes tener " + te.NumeroGatos + " gatos");
            }
            catch(NullReferenceException ne)
            {
                // Maejamos el error relacionado con objetos nulos
            } 
            catch(ArithmeticException)
            {
                // Manejamos cualquier error relacionad 
                // con desborde de números o divisiones entre 0
            }
            catch
            {
                // Manejamos cualquier otra excepción
            }

            RelanzaExcepcion();
        }

        private static void RelanzaExcepcion()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch(Exception e)
            {
                // Logging
                //throw e; // ¡No lo hagas, es malo!
                throw;
            }
        }
    }

    public class TienesMuchosGatosException : Exception
    {

        public int NumeroGatos { get; private set; }

        public TienesMuchosGatosException(int numeroGatos)
            : base("¡" + numeroGatos + " son muchos gatos!")
        {
            NumeroGatos = numeroGatos;
        }
    }
}
