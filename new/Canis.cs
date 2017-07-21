using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    /// <summary>
    /// Canis es un género de mamíferos placentarios de la familia Canidae, 
    /// orden de los carnívoros, que incluye los perros, lobos, chacales, coyotes y dingos.
    /// </summary>
    public abstract class Canis
    {
        public string EstadoConservacion { get; set; }
        public string Especie { get; set; }
    }
}
