using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Catering;
using Entity_Catering;
using NLog;

namespace BLL_Catering
{
    public class EventosBLL
    {
        private readonly EventoDAL _eventosDAL;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public EventosBLL()
        {
            _eventosDAL = new EventoDAL();
        }

        public List<Evento> ListarEventos()
        {
            DAL_Catering.EventoDAL dalEventos = new DAL_Catering.EventoDAL();

            List<Entity_Catering.Evento> eventosAux = dalEventos.Listar();

            return eventosAux;
        }

        public List<Evento> OneEvento(int id_evento)
        {
            DAL_Catering.EventoDAL dalEventos = new DAL_Catering.EventoDAL();

            List<Entity_Catering.Evento> eventosAux = dalEventos.OneEvento(id_evento);

            return eventosAux;
        }

        public Boolean AddEvento(Evento creaEvento)
        {
            DAL_Catering.EventoDAL dalEventos = new DAL_Catering.EventoDAL();

            Boolean boolEvento = dalEventos.AddEvento(creaEvento);

            return boolEvento;
        }

        public Boolean UpdateEvento(Evento UpdateEvento)
        {
            DAL_Catering.EventoDAL dalEventos = new DAL_Catering.EventoDAL();

            Boolean boolEvento = dalEventos.UpdateEvento(UpdateEvento);

            return boolEvento;
        }

        public List<EventoEntity> BuscarEventosPorFechaYEstado(DateTime fechaDesde, DateTime fechaHasta, string estado)
        {
            try
            {
                if (fechaDesde > fechaHasta)
                {
                    throw new ArgumentException("La fecha de inicio no puede ser mayor que la fecha de fin.");
                }
                return _eventosDAL.BuscarEventoPorFechaYEstado(fechaDesde, fechaHasta, estado);
            }
            catch (Exception ex) { 
                logger.Error(ex);
                throw;
            }
        }

        public int ActualizarEstadoEvento(int idEvento, string nuevoEstado)
        {
            try
            {
                return _eventosDAL.ActualizarEstadoEvento(idEvento, nuevoEstado);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
        }

        public List<Evento> GetEventoByIdCliente(int id)
        {
            DAL_Catering.EventoDAL dalEventos = new DAL_Catering.EventoDAL();

            List<Entity_Catering.Evento> eventosAux = dalEventos.GetEventoByIdCliente(id);

            return eventosAux;
        }

    }
}
