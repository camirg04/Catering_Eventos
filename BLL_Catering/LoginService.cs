using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;
using NLog;

namespace BLL_Catering
{
    public class LoginService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public LoginService() { }
        /*un comentario*/
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
            try {
                DAL_Catering.LoginDAL loginDAL = new DAL_Catering.LoginDAL();
                Usuario usuario =  loginDAL.BuscarUsuarioPorCredenciales(mail);
                if (usuario == null)
                {
                    return null;
                }
                else
                {
                    if (usuario.Clave != clave)
                    {
                        return null;
                    }
                    else
                    {
                        return usuario;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al intentar loguear usuario en BLL");
                throw ex;
            }
            
        }
    }
}
