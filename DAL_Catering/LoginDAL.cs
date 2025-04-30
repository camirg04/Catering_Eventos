using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;

namespace DAL_Catering
{
    public class LoginDAL
    {
        Conexion conexion;
        public LoginDAL() {
            conexion = new Conexion();
        }

        public Usuario BuscarUsuarioPorCredenciales(string email, string clave)
        {
            // Consulta SQL parametrizada
            string consulta = @"select id_usuario, email, perfil,e.nombre from usuarios u inner join empleado e  on u.id_empleado = e.id_empleado
            where email = @Email AND clave = @Clave and u.fecha_baja is null ";

            // Crear parámetros
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Email", SqlDbType.VarChar, 100) { Value = email },
                new SqlParameter("@Clave", SqlDbType.VarChar, 50) { Value = clave }
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
                Email = row["email"].ToString(),
                Perfil = row["perfil"].ToString(),
                Nombre = row["nombre"].ToString()
            };
        }
    }
}
