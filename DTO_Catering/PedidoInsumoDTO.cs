using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;

namespace DTO_Catering
{
    public class PedidoInsumoDTO
    {
        private int _idPedidoInsumo;
        private string _nombreInsumo;
        private int _idInsumo;
        private string _nombreUsuario;
        private Decimal _cantidad;
        private DateTime? _fechaPedido;
        private string _estadoPedido;
        private string _unidadMedida;

        public PedidoInsumoDTO() { }

        public PedidoInsumoDTO(int idPedidoInsumo, string nombreInsumo, int idInsumo, string nombreUsuario, Decimal cantidad, DateTime? fechaPedido, string estadoPedido, string unidadMedida)
        {
            _idPedidoInsumo = idPedidoInsumo;
            _nombreInsumo = nombreInsumo;
            _idInsumo = idInsumo;
            _nombreUsuario = nombreUsuario;
            _cantidad = cantidad;
            _fechaPedido = fechaPedido;
            _estadoPedido = estadoPedido;
            _unidadMedida = unidadMedida;
        }

        public int IdPedidoInsumo { get => _idPedidoInsumo; set => _idPedidoInsumo = value; }

        [DisplayName("Producto")]
        public string NombreInsumo { get => _nombreInsumo; set => _nombreInsumo = value; }
        public int IdInsumo { get => _idInsumo; set => _idInsumo = value; }
    
        public decimal Cantidad { get => _cantidad; set => _cantidad = value; }

        [DisplayName("Unidad")]
        public string UnidadMedida { get => _unidadMedida; set => _unidadMedida = value; }

        [DisplayName("Fecha pedido")]
        public DateTime? FechaPedido { get => _fechaPedido; set => _fechaPedido = value; }

        [DisplayName("Estado")]
        public string EstadoPedido { get => _estadoPedido; set => _estadoPedido = value; }
        [DisplayName("Empleado")]
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }


        public static List<PedidoInsumoDTO> mapListPedidoInsumoToListPedidoInsumoDTO(List<PedidoInsumo> listaPedidos)
        {
            List<PedidoInsumoDTO> listaPedidosDTO = new List<PedidoInsumoDTO>();
            foreach (var pedido in listaPedidos)
            {
                PedidoInsumoDTO pedidoDTO = new PedidoInsumoDTO
                {
                    IdPedidoInsumo = pedido.IdPedidoInsumo,
                    NombreInsumo = pedido.Insumo.Nombre,
                    IdInsumo = pedido.Insumo.IdInsumo,
                    NombreUsuario = $"{pedido.UsuarioPedido.Nombre} {pedido.UsuarioPedido.Apellido}",
                    Cantidad = pedido.Cantidad,
                    FechaPedido = pedido.FechaPedido,
                    EstadoPedido = pedido.EstadoPedido,
                    UnidadMedida = pedido.Insumo.UnidadMedida
                };
                listaPedidosDTO.Add(pedidoDTO);
            }
            return listaPedidosDTO;
        }
    }
}
