using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    [System.AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    sealed class ValidCarrierAttribute : Attribute
    {
    }
}
