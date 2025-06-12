using DAL_Catering;
using Entity_Catering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Catering
{
    public class ClienteBLL
    {

        private readonly ClienteDAL _clienteDAL;

        public ClienteBLL()
        {
            _clienteDAL = new ClienteDAL();
        }

        public List<Cliente> ListarClientes()
        {
            DAL_Catering.ClienteDAL dalCliente = new DAL_Catering.ClienteDAL();

            List<Entity_Catering.Cliente> dalClienteAux = dalCliente.Listar();

            return dalClienteAux;
        }
        public Cliente ListarOneCliete(int idCliente)
        {

            DAL_Catering.ClienteDAL dalCliente = new DAL_Catering.ClienteDAL();

            List<Entity_Catering.Cliente> dalClienteAux = dalCliente.Listar();

            foreach (Cliente c in dalClienteAux)
            {
                if (c.Id == idCliente)
                {
                    return c;
                }

            }

            throw new Exception("Cliente no encontrado");

        }

        public bool AddCliente(Cliente cliente)
        {
            try
            {
                if (cliente.Nombre != "" || cliente.Apellido != "" || cliente.Telefono != "" || cliente.Direccion != "" || cliente.DNI != "" || cliente.Email != "")
                {
                    ClienteDAL clienteDAL = new ClienteDAL();
                    return clienteDAL.AddCliente(cliente);
                }
                else
                {
                    throw new Exception("Faltan ingresar datos");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Tuvimos un error al guardar al cliente: " + ex.Message);
            }

        }

        public bool UpdateCliente(Cliente cliente)
        {

            try
            {
                if (cliente.Nombre != "" || cliente.Apellido != "" || cliente.Telefono != "" || cliente.Direccion != "" || cliente.DNI != "" || cliente.Email != "")
                {
                    ClienteDAL clienteDAL = new ClienteDAL();
                    return clienteDAL.UpdateCliente(cliente);
                }
                else
                {
                    throw new Exception("Faltan ingresar datos");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Tuvimos un error al actualizar al cliente: " + ex.Message);

            }
        }
    }
}
