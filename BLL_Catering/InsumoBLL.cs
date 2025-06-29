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


        public List<Insumo> BuscarInsumos(string nombre, string activo)
        {
            try
            {
                return _insumoDal.BuscarInsumos(nombre,activo);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw ex;
            }
        }

        public bool AgregarInsumo(Insumo insumo)
        {
            try
            {
                return _insumoDal.AgregarInsumo(insumo) > 0;
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "Error de validación al agregar insumo");
                throw;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al agregar insumo");
                throw ex;
            }
        }

        public bool EditarInsumo(Insumo insumo)
        {
            try
            {
                return _insumoDal.EditarInsumo(insumo) > 0;
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "Error de validación al editar insumo");
                throw;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar insumo");
                throw ex;
            }
        }
    }
}
