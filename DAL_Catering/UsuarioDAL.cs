using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity_Catering;
using System.Data.SqlClient;
using NLog;
using System.CodeDom;



namespace DAL_Catering
{
    public class UsuarioDAL
    {
        private readonly Conexion conexion;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public UsuarioDAL(){
            conexion = new Conexion();
        }
        public List<Usuario> ListarActivos()
        {

            List<Usuario> usuarios = new List<Usuario>();
            DataTable dt = conexion.LeerPorStoreProcedure("sp_todoUsuarios");


            foreach (DataRow fila in dt.Rows)
            {

                Usuario unUsuario = new Usuario();

                unUsuario.IdUsuario = int.Parse(fila["id_usuario"].ToString());
                unUsuario.Email = fila["email"].ToString();
                unUsuario.Clave = fila["clave"].ToString();
                unUsuario.Perfil = fila["perfil"].ToString();
                unUsuario.FechaCreacion = DateTime.Parse(fila["fecha_creacion"].ToString());
                unUsuario.FechaBajaUsuario = null;
                unUsuario.DNI = fila["dni_empleado"].ToString();
                unUsuario.Nombre = fila["nombre"].ToString();
                unUsuario.Apellido = fila["apellido"].ToString();
                unUsuario.Domicilio = fila["domicilio"].ToString();
                unUsuario.Telefono = fila["telefono"].ToString();

                usuarios.Add(unUsuario);
                
            }

            return usuarios;
        }

        public Boolean CrearUsuario(Entity_Catering.Usuario usuarioAux)
        {
            SqlParameter[] parametros = {
           
                new SqlParameter("inNombre", usuarioAux.Nombre),
                new SqlParameter("inApellido", usuarioAux.Apellido),
                new SqlParameter("inDomicilio", usuarioAux.Domicilio),
                new SqlParameter("inTelefono", usuarioAux.Telefono),
                new SqlParameter("inDniEmpleado", usuarioAux.DNI ),
                new SqlParameter("inFechaCreacion", usuarioAux.FechaCreacion),
                new SqlParameter("inPerfil", usuarioAux.Perfil),
                new SqlParameter("inClave", usuarioAux.Clave),
                new SqlParameter("inEmail", usuarioAux.Email),
                
            };

            try
            {
                // Ejecutar consulta
                int filasAfectadas = conexion.EscribirPorStoreProcedure("sp_agregarUsuario", parametros);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool EditarUsuario(Usuario usuarioAux)
        {

            SqlParameter[] parametros =
            {
                new SqlParameter("inNombre", usuarioAux.Nombre),
                new SqlParameter("inApellido", usuarioAux.Apellido),
                new SqlParameter("inDomicilio", usuarioAux.Domicilio),
                new SqlParameter("inTelefono", usuarioAux.Telefono),
                new SqlParameter("inDniEmpleado", usuarioAux.DNI ),
                new SqlParameter("inPerfil", usuarioAux.Perfil),
                new SqlParameter("inClave", usuarioAux.Clave),
                new SqlParameter("inEmail", usuarioAux.Email),
                new SqlParameter("inId", usuarioAux.IdUsuario)

            };

            try
            {
                int filasAfectadas = conexion.EscribirPorStoreProcedure("sp_editarUsuario", parametros);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }



        }

        public bool BajaUsuario(Usuario usuarioAux)
        {
       

            SqlParameter[] parametros =
          {
                new SqlParameter("inNombre", usuarioAux.Nombre),
                new SqlParameter("inApellido", usuarioAux.Apellido),
                new SqlParameter("inDomicilio", usuarioAux.Domicilio),
                new SqlParameter("inTelefono", usuarioAux.Telefono),
                new SqlParameter("inDniEmpleado", usuarioAux.DNI ),
                new SqlParameter("inPerfil", usuarioAux.Perfil),
                new SqlParameter("inClave", usuarioAux.Clave),
                new SqlParameter("inEmail", usuarioAux.Email),
                new SqlParameter("inFechaBaja", DateTime.Now)

            };


            try
            {
                int filasAfectadas = conexion.EscribirPorStoreProcedure("sp_bajaUsuario", parametros);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return false;
            }

        }

        public List<string> ObtenerMailsLogisticaChefs()
        {

            try
            {
                List<string> mails = new List<string>();
                DataTable dt = conexion.LeerPorStoreProcedure("sp_ObtenerMailsLogisticaChefs");

                foreach (DataRow fila in dt.Rows)
                {

                    mails.Add(fila["email"].ToString());


                }
                return mails;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
        }


    }
}
