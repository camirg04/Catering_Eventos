using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;
using DAL_Catering;
using NLog;

namespace BLL_Catering
{
    public class PlatoBLL
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public PlatoBLL() { }

        public List<Plato> BuscarPlatosActivos()
        {
            try
            {
                PlatoDAL platoDAL = new PlatoDAL();
                return platoDAL.BuscarPlatosActivos();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al buscar platos activos en BLL");
                throw ex;
            }
        }
    }
}
