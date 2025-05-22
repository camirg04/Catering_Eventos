using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Catering
{
    public interface PerfilUsuario
    {
        string darBienvenida(string nombreUsuario);
        void cerrarSesion();
    }
}
