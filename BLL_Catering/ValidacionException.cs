using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Catering
{
    public class ValidacionException : Exception
    {
        public ValidacionException()
        : base("Error en la validación de datos.") { }

        public ValidacionException(string mensaje)
            : base(mensaje) { }

    }
}
