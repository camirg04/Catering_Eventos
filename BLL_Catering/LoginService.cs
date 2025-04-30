using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;

namespace BLL_Catering
{
    public class LoginService
    {

        public LoginService() { }

        public string ValidarUsuario(string usuario)
        {
            string response = !(usuario == "" || usuario == null) ? "" : "El usuario no puede estar vacío";
            return response;
        }
        public string ValidarClave(string clave)
        {
            string response = !(clave == "" || clave == null) ? "" : "La clave no puede estar vacía";
            return response;
        }

        public Usuario LoginUsuario(string mail, string clave)
        {
            DAL_Catering.LoginDAL loginDAL = new DAL_Catering.LoginDAL();
            return loginDAL.BuscarUsuarioPorCredenciales(mail, clave);
        }
    }
}
