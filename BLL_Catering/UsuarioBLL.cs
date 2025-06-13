using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DAL_Catering;
using Entity_Catering;
using NLog;

namespace BLL_Catering
{
    public class UsuarioBLL
    {

        private readonly UsuarioDAL _empleadosDal;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public UsuarioBLL() {
            _empleadosDal = new UsuarioDAL();
        }


        public List<Usuario> ListarEmpleados()
        {
            DAL_Catering.UsuarioDAL dalEmpleado = new DAL_Catering.UsuarioDAL();

            List<Usuario> empleados = dalEmpleado.Listar();

            List<Usuario> auxEmpleado = empleados;


            return auxEmpleado;
        }


        public string ValidarUsuario(string usuario)
        {
            string response = !(usuario == null || usuario.Trim() == "") ? "" : "El usuario no puede estar vacío";
            return response;
        }
        public string ValidarClave(string clave)
        {
            string response = !(clave == null || clave.Trim() == "") ? "" : "La clave no puede estar vacía";
            return response;
        }

        public Usuario LoginUsuario(string mail, string clave)
        {
            try
            {
                DAL_Catering.LoginDAL loginDAL = new DAL_Catering.LoginDAL();
                Usuario usuario = loginDAL.BuscarUsuarioPorCredenciales(mail);
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


        public List<string> ObtenerMailsLogisticaChefs()
        {
            try
            {
               return _empleadosDal.ObtenerMailsLogisticaChefs();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al buscar mails en BLL");
                throw ex;
            }
        }

    }
}
