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


        //creo una lista de los usuarios activos del sistema.
        public List<Usuario> ListarActivos()
        {
            DAL_Catering.UsuarioDAL dalUsuario = new DAL_Catering.UsuarioDAL();

            List<Usuario> usuariosActivos = dalUsuario.ListarActivos();

            return usuariosActivos;
        }

        public List<Usuario> BuscarActivos(string dniAux, string apellidoAux)
        {
            DAL_Catering.UsuarioDAL dalUsuario = new DAL_Catering.UsuarioDAL();

            List<Usuario> listAux = dalUsuario.ListarActivos();
            List<Usuario> aux = new List<Usuario>();



            foreach (Usuario u in listAux)
            {
                if (u.DNI == dniAux)
                {
                    aux.Add(u);
                }
                else if (u.Apellido == apellidoAux)
                {
                    aux.Add(u);
                }

            }
            return aux;

        }
        public Usuario CrearUsuario(string nombre, string apellido, string dni, string domicilio,string telefono, string perfil,string email, string clave, DateTime fechaCreacion)
        {
            Usuario userAux = new Usuario();

            userAux.Nombre = nombre;
            userAux.Apellido = apellido;
            userAux.DNI = dni;
            userAux.Domicilio = domicilio;
            userAux.Telefono = telefono;
            userAux.Perfil = perfil;
            userAux.Email = email;
            userAux.Clave = clave;
            userAux.FechaCreacion = fechaCreacion;

            return userAux;

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
