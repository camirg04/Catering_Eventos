using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Catering;
using Entity_Catering;

namespace BLL_Catering
{
    public class EventosBLL
    {
        private readonly EventoDAL _eventosDAL;



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

        public List<Evento> GetEventoByIdCliente(int id)
        {
            DAL_Catering.EventoDAL dalEventos = new DAL_Catering.EventoDAL();

            List<Entity_Catering.Evento> eventosAux = dalEventos.GetEventoByIdCliente(id);

            return eventosAux;
        }

    }
}
