using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;
using NLog;

namespace DAL_Catering
{
    public class LoginDAL
    {
        private readonly Conexion conexion;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public LoginDAL() {
            conexion = new Conexion();
        }

        public Usuario BuscarUsuarioPorCredenciales(string email)
        {
            try
            {
                // Consulta SQL parametrizada
                string consulta = @"select id_usuario, email, perfil, nombre, clave from usuarios
                where email = @Email and fecha_baja is null ";

                // Crear parámetros
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@Email", SqlDbType.VarChar, 100) { Value = email }
                };

                // Ejecutar consulta
                DataTable resultado = conexion.LeerPorComando(consulta, parametros);

                // Si no hay resultados, retornar null
                if (resultado?.Rows.Count == 0)
                    return null;

                // Mapear DataRow a objeto Usuario
                DataRow row = resultado.Rows[0];
                return new Usuario
                {
                    IdUsuario = Convert.ToInt32(row["id_usuario"]),
                    Clave = row["clave"].ToString(),
                    Email = row["email"].ToString(),
                    Perfil = row["perfil"].ToString(),
                    Nombre = row["nombre"].ToString()
                };

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al buscar usuario por credenciales");
                throw ex;
            }
            
        }
    }
}
