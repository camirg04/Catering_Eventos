using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using DAL_Catering;
using DTO_Catering;


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

    }
}
