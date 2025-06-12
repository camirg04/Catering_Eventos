using Entity_Catering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Catering
{
    public class ClienteDAL
    {
        private readonly Conexion conexion;
        public ClienteDAL() {
            conexion = new Conexion();
        }

        public List<Entity_Catering.Cliente> Listar()
        {
            List<Entity_Catering.Cliente> clientes = new List<Entity_Catering.Cliente>();

            DataTable dt = conexion.LeerPorStoreProcedure("sp_allCliente");

            foreach (DataRow fila in dt.Rows)
            {
                Entity_Catering.Cliente cliente = new Entity_Catering.Cliente();
                cliente.Id = int.Parse(fila["id_cliente"].ToString());
                cliente.Nombre = fila["nombre"].ToString();
                cliente.Apellido = fila["apellido"].ToString();
                cliente.Email = fila["email"].ToString();
                cliente.Telefono =fila["telefono"].ToString();
                cliente.Direccion = fila["domicilio"].ToString();
                cliente.DNI = fila["dni"].ToString();

                clientes.Add(cliente);

            }

            return clientes;

        }

        public bool AddCliente(Cliente cliente)
        {
            /*@nombre varchar(100),
            @apellido varchar(100),
            @email varchar(100),
            @telefono varchar(20),
            @domicilio varchar(100),
            @dni varchar(45)*/
            SqlParameter[] valores = {
                new SqlParameter("nombre", cliente.Nombre),
                new SqlParameter("apellido", cliente.Apellido ),
                new SqlParameter("email", cliente.Email),
                new SqlParameter("telefono", cliente.Telefono),
                new SqlParameter("domicilio", cliente.Direccion ),
                new SqlParameter("dni", cliente.DNI )
            };

            try
            {
                // Ejecutar consulta
                int filasAfectadas = conexion.EscribirPorStoreProcedure("sp_addCliente", valores);
                return true;
            }
            catch (Exception ex)
            {
                //logger.Error("Tuvimos un error al guardar"+ex.Message);
                Console.WriteLine(ex.ToString());
                throw ex;

            }

        }

        public  bool UpdateCliente(Cliente cliente)
        {
            SqlParameter[] valores = {
                new SqlParameter("id_cliente", cliente.Id),
                new SqlParameter("nombre", cliente.Nombre),
                new SqlParameter("apellido", cliente.Apellido ),
                new SqlParameter("email", cliente.Email),
                new SqlParameter("telefono", cliente.Telefono),
                new SqlParameter("domicilio", cliente.Direccion ),
                new SqlParameter("dni", cliente.DNI )
            };

            try
            {
                // Ejecutar consulta
                int filasAfectadas = conexion.EscribirPorStoreProcedure("sp_updateCliente", valores);
                return true;
            }
            catch (Exception ex)
            {
                //logger.Error("Tuvimos un error al guardar"+ex.Message);
                Console.WriteLine(ex.ToString());
                throw ex;

            }

        }


    }
}
