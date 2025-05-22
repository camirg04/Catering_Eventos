using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Catering
{
    public class PedidoInsumo
    {
        private int _idPedidoInsumo;
        private Insumo _insumo;
        private Usuario _usuarioPedido;
        private Decimal _cantidad;
        private DateTime? _fechaPedido;
        private string _estadoPedido;
        public PedidoInsumo() { }

        public PedidoInsumo(int idPedidoInsumo, Insumo insumo, Usuario usuarioPedido, Decimal cantidad, DateTime? fechaPedido, string estadoPedido)
        {
            _idPedidoInsumo = idPedidoInsumo;
            _insumo = insumo;
            _usuarioPedido = usuarioPedido;
            _cantidad = cantidad;
            _fechaPedido = fechaPedido;
            _estadoPedido = estadoPedido;
        }

        public int IdPedidoInsumo
        {
            get { return _idPedidoInsumo; }
            set { _idPedidoInsumo = value; }
        }

        public Insumo Insumo
        {
            get { return _insumo; }
            set { _insumo = value; }
        }

        public Usuario UsuarioPedido
        {
            get { return _usuarioPedido; }
            set { _usuarioPedido = value; }
        }

        public Decimal Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public DateTime? FechaPedido
        {
            get { return _fechaPedido; }
            set { _fechaPedido = value; }
        }

        public string EstadoPedido
        {
            get { return _estadoPedido; }
            set { _estadoPedido = value; }
        }

    }
}
