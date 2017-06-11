using System;
namespace Excepciones
{
    public class Adulto
    {
        public Adulto()
        {
        }

        private int _numeroGatos;
        public int NumeroGatos
        {
            get { return _numeroGatos; }
            set
            {
                if (value > 4)
                    throw new TienesMuchosGatosException(value);
                _numeroGatos = value;
            }
        } 
    }
}
