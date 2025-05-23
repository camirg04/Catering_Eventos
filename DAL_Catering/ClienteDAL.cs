using Entity_Catering;
using System;
using System.Collections.Generic;
using System.Data;
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


    }
}
