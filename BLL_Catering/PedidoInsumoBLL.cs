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
            try
            {
                return _pedidoInsumoDAL.ObtenerPedidoInsumo();
            }
            catch (Exception ex) {
                throw;
            }           
        }

        public List<PedidoInsumo> ObtenerPedidoInsumoBLL(int idInsumo, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            try
            {
                return _pedidoInsumoDAL.ObtenerPedidoInsumo(idInsumo,fechaDesde,fechaHasta);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool UpdatePedidoInsumoBLL(int idInsumo,int idPedidoInsumo,DateTime fechaPedidoInsumo,string entregado, Decimal cantidad,int costo, string estadoAnterior)    
        {
            try
            {               
                ValidarCambioEstadoPedido(estadoAnterior, entregado);
                return _pedidoInsumoDAL.UpdatePedidoInsumoBLL(idInsumo, idPedidoInsumo, fechaPedidoInsumo, entregado, cantidad, costo);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void ValidarCambioEstadoPedido(string estadoAnterior, string estadoNuevo)
        {
            if (estadoAnterior == estadoNuevo)
                return;

            if (estadoAnterior == "ENTREGADO")
                throw new ArgumentException("No se puede modificar el estado de un pedido 'Entregado'");
            if (estadoAnterior == "CANCELADO")
                throw new ArgumentException("No se puede modificar el estado de un pedido 'Cancelado'");
        }

        public bool AddPedidoInsumoBll(int idInsumo, DateTime fecha_pedido, string estado, Decimal cantidad, int idUsuario)
        {
            try
            {
                return _pedidoInsumoDAL.AddPedidoInsumoDAL(idInsumo, fecha_pedido, estado, cantidad, idUsuario);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

    }
}
