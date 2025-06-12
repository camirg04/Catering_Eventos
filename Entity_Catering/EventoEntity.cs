using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Catering
{
    public class EventoEntity
    {
        private int _idEvento;
        private Cliente _cliente;
        private Menus menu;
        private Vendedor _usuarioVenta;
        private DateTime _fechaEvento;
        private Decimal _descuentoAplicado;
        private string _direccion;
        private string _localidad;
        private string _estadoEvento;
        private int _cantidadPersonas;
        private Decimal _totalEstimado;
        private bool _eventoPago;

        public EventoEntity()
        {
        }

        public EventoEntity(Cliente cliente, Menus menu, Vendedor usuarioVenta, DateTime fechaEvento, Decimal descuentoAplicado, string direccion, string localidad, string estadoEvento, int cantidadPersonas, Decimal totalEstimado, bool eventoPago)
        {
            Cliente = cliente;
            this.Menu = menu;
            UsuarioVenta = usuarioVenta;
            FechaEvento = fechaEvento;
            DescuentoAplicado = descuentoAplicado;
            Direccion = direccion;
            Localidad = localidad;
            EstadoEvento = estadoEvento;
            CantidadPersonas = cantidadPersonas;
            TotalEstimado = totalEstimado;
            EventoPago = eventoPago;
        }

        public int IdEvento { get => _idEvento; set => _idEvento = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public Menus Menu { get => menu; set => menu = value; }
        public Vendedor UsuarioVenta { get => _usuarioVenta; set => _usuarioVenta = value; }
        public DateTime FechaEvento { get => _fechaEvento; set => _fechaEvento = value; }
        public decimal DescuentoAplicado { get => _descuentoAplicado; set => _descuentoAplicado = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Localidad { get => _localidad; set => _localidad = value; }
        public string EstadoEvento { get => _estadoEvento; set => _estadoEvento = value; }
        public int CantidadPersonas { get => _cantidadPersonas; set => _cantidadPersonas = value; }
        public decimal TotalEstimado { get => _totalEstimado; set => _totalEstimado = value; }
        public bool EventoPago { get => _eventoPago; set => _eventoPago = value; }

    }
}
