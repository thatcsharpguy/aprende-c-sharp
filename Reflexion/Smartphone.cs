using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    public class Smartphone
    {
        [Required]
        [ValidCarrier]
        [Display(Name ="Compañía")]
        public string Carrier { get; set; }

        [Display(Name = "Bloqueado")]
        public bool IsLocked { get; set; }

        [Display(Name = "Numero de contactos")]
        public int ContactCount { get; set; }

    }
}
