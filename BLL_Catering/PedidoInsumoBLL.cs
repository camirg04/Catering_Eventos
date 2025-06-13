using DAL_Catering;
using Entity_Catering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Catering
{
    public class PedidoInsumoBLL
    {

        private readonly PedidoInsumoDAL _pedidoInsumoDAL;

        public PedidoInsumoBLL()
        {
            _pedidoInsumoDAL = new PedidoInsumoDAL();
        }

        public List<PedidoInsumo> ObtenerPedidoInsumoBLL()
        {
            return _pedidoInsumoDAL.ObtenerPedidoInsumo();
        }

        public bool UpdatePedidoInsumoBLL(int idInsumo,int idPedidoInsumo,DateTime fechaPedidoInsumo,string entregado, Decimal cantidad,int costo)
       
        {

            _pedidoInsumoDAL.UpdatePedidoInsumoBLL(idInsumo, idPedidoInsumo, fechaPedidoInsumo, entregado, cantidad,costo);
            return true;

        }
        public bool AddPedidoInsumoBll(int idPedidoInsumo, int idInsumo, DateTime fecha_pedido, string estado, Decimal cantidad, int idUsuario)
        {
            _pedidoInsumoDAL.AddPedidoInsumoDAL(idPedidoInsumo, idInsumo, fecha_pedido, estado, cantidad, idUsuario);
            return true;
        }

    }
}
