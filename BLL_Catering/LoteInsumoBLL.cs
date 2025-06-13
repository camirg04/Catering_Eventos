using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using DAL_Catering;
using DTO_Catering;
using Entity_Catering;


namespace BLL_Catering
{
    public class LoteInsumoBLL
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly LoteInsumoDAL _loteInsumoDal;

        public LoteInsumoBLL()
        {
            _loteInsumoDal = new LoteInsumoDAL();
        }

        public List<LoteInsumoDTO> ObtenerLotesInsumos()
        {
            try
            {
                var listaLotes = _loteInsumoDal.ListarLotes();
                return listaLotes.Select(LoteInsumoDTO.mapLoteInsumoToLoteInsumoDTO).ToList();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al obtener lotes de insumos");
                throw;
            }
        }

        public List<LoteInsumoDTO> ObtenerLotesInsumosPerecederos(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                if(fechaDesde > fechaHasta)
                {
                    throw new ArgumentException("La fecha de inicio no puede ser mayor que la fecha de fin.");
                }
                var listaLotes = _loteInsumoDal.ListarLotesPerecederos(fechaDesde, fechaHasta);
                var dto =  listaLotes.Select(LoteInsumoDTO.mapLoteInsumoToLoteInsumoDTO).ToList();
                foreach ( var item in dto)
                {
                    AsignarSeveridad(item);
                }
                return dto;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al obtener lotes de insumos");
                throw;
            }
        }

        public List<LoteInsumo> ObtenerLotesInsumosPorIdInsumo(int id_insumo)
        {
            try
            {
                return _loteInsumoDal.ListarLotesPorIdInsumo(id_insumo);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al obtener lotes de insumos");
                throw;
            }
        }

        private void AsignarSeveridad(LoteInsumoDTO lote)
        {
            if(lote.FechaVencimiento == null)
            {
                lote.Severidad = "Nula";
                return;
            }

            TimeSpan? diferencia =  lote.FechaVencimiento - DateTime.Now;
            int dias = (int)diferencia?.Days;

                   
            
            if (dias <=3 )
            {
                lote.Severidad = "Crítica";
            }
            else if (dias <= 7)
            {
                lote.Severidad = "Mayor";
            }else if (dias <= 15)
            {
                lote.Severidad = "Menor";
            }
            else
            {
                lote.Severidad = "Nula";
            }

        }
        public int ActualizarCantidadLote(int idLote, decimal cantidad)
        {
            try
            {
                return _loteInsumoDal.ActualizarCantidadLote(idLote,cantidad);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al obtener lotes de insumos");
                throw;
            }
        }

    }
}
