using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Catering;
using NLog;
using Entity_Catering;

namespace BLL_Catering
{
    public class InsumoBLL
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly InsumoDAL _insumoDal;

        public InsumoBLL()
        {
            _insumoDal = new InsumoDAL();
        }

        public List<Insumo> ObtenerInsumosActivos()
        {
            try
            {
                return _insumoDal.ObtenerInsumosActivos();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al obtener insumos activos");
                throw ex;
            }
        }
    }
}
