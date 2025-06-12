using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Catering;
using DTO_Catering;
using Entity_Catering;

namespace BLL_Catering
{
    public class AlertaStockBLL
    {
        private AlertaStockDAL _alertaStockDAL;

        public AlertaStockBLL()
        {
            _alertaStockDAL = new AlertaStockDAL();
        }

        public List<AlertaStockDTO> FiltrarAlertas(DateTime fechaDesde, DateTime fechaHasta, string estado)
        {
            try
            {
                var alertas = _alertaStockDAL.FiltrarAlertas(fechaDesde, fechaHasta, estado);
                var alertasDTO = AlertaStockDTO.mapListAlertaStockToListAlertaStockDTO(alertas);
                foreach (var al in alertasDTO)
                {
                    AsignarSeveridad(al);
                }
                return alertasDTO;
            }
            catch (Exception ex)
            {
                // Aquí podrías manejar la excepción de manera más específica o registrar el error
                throw new Exception("Error al filtrar alertas de stock", ex);
            }
        }


        private void AsignarSeveridad(AlertaStockDTO alerta)
        {
            DateTime fechaAlerta = alerta.FechaAlerta.Value;
            TimeSpan diferencia = DateTime.Now - fechaAlerta;
            int dias = diferencia.Days;
            if(alerta.EstadoAlerta == "RESUELTO")
            {
                alerta.Severidad = "-";
                return;
            }
            if (dias >= 7)
            {
                alerta.Severidad = "Crítica";
            }
            else if (dias > 2)
            {
                alerta.Severidad = "Mayor";
            }
            else
            {
                alerta.Severidad = "Menor";
            }

        }
    }
}
