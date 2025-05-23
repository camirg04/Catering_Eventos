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
    }
}
