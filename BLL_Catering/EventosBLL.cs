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



    }
}
