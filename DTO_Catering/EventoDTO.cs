using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;

namespace DTO_Catering
{
    public class EventoDTO
    {
        private int _idEvento;
        private int _IdCliente;
        private string _cliente;
        private int _idMenu;
        private string _nombreMenu;
        private string _usuarioVenta;
        private DateTime _fechaEvento;
        private Decimal _descuentoAplicado;
        private string _direccion;
        private string _localidad;
        private string _estadoEvento;
        private int _cantidadPersonas;
        private Decimal _totalEstimado;
        private string _eventoPago;


        public EventoDTO()
        {
        }

        public int IdEvento { get => _idEvento; set => _idEvento = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public string Cliente { get => _cliente; set => _cliente = value; }
        public int IdMenu { get => _idMenu; set => _idMenu = value; }
        public string NombreMenu { get => _nombreMenu; set => _nombreMenu = value; }
        public string UsuarioVenta { get => _usuarioVenta; set => _usuarioVenta = value; }
        public DateTime FechaEvento { get => _fechaEvento; set => _fechaEvento = value; }
        public decimal DescuentoAplicado { get => _descuentoAplicado; set => _descuentoAplicado = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Localidad { get => _localidad; set => _localidad = value; }
        public string EstadoEvento { get => _estadoEvento; set => _estadoEvento = value; }
        public int CantidadPersonas { get => _cantidadPersonas; set => _cantidadPersonas = value; }
        public decimal TotalEstimado { get => _totalEstimado; set => _totalEstimado = value; }
        public string EventoPago { get => _eventoPago; set => _eventoPago = value; }


        public static EventoDTO mapEventoToEventoDTO(EventoEntity evento)
        {
            var eventoDTO = new EventoDTO();
            eventoDTO.IdEvento = evento.IdEvento;
            eventoDTO.IdCliente = evento.Cliente.Id;
            eventoDTO.Cliente = evento.Cliente.Nombre;
            eventoDTO.IdMenu = evento.Menu.IdMenu;
            eventoDTO.NombreMenu = evento.Menu.Nombre;
            eventoDTO.UsuarioVenta = evento.UsuarioVenta.Nombre;
            eventoDTO.FechaEvento = evento.FechaEvento;
            eventoDTO.DescuentoAplicado = evento.DescuentoAplicado;
            eventoDTO.Direccion = evento.Direccion;
            eventoDTO.Localidad = evento.Localidad;
            eventoDTO.EstadoEvento = evento.EstadoEvento;
            eventoDTO.CantidadPersonas = evento.CantidadPersonas;
            eventoDTO.TotalEstimado = evento.TotalEstimado;
            eventoDTO.EventoPago = evento.EventoPago ? "Sí" : "No";


            return eventoDTO;
        }

        public static List<EventoDTO> mapEventoListToEventoDTOList(List<EventoEntity> eventos)
        {
            List<EventoDTO> eventosDTO = new List<EventoDTO>();
            foreach (var evento in eventos)
            {
                eventosDTO.Add(mapEventoToEventoDTO(evento));
            }
            return eventosDTO;
        }
    }
}
