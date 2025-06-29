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
    public class LogisticaBLL
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly InsumoBLL _insumoBLL;
        private readonly ValidacionesBLL _validacionesBLL;
        public LogisticaBLL()
        {
            _insumoBLL = new InsumoBLL();
            _validacionesBLL = new ValidacionesBLL();
        }

        public List<Insumo> BuscarInsumos(string nombre, string activo)
        {
            try
            {
                return _insumoBLL.BuscarInsumos(nombre, activo);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw ex;
            }
        }

        public void ValidarDatosInsumo(string nombre, string unidadMedida, string stockMinimo, string perecedero,string activo)
        {
            if (nombre == null || nombre.Trim() == "")
            {
                throw new ArgumentException("Debe ingresar el nombre del insumo.");
            }

            if (unidadMedida == null || unidadMedida.Trim() == "")
            {
                throw new ArgumentException("Debe especificar la unidad de medida.");
            }

            if (perecedero == null || perecedero.Trim() == "")
            {
                throw new ArgumentException("Debe indicar si el insumo es perecedero.");
            }
            if (stockMinimo == null || stockMinimo.Trim() == "")
            {
                throw new ArgumentException("Debe especificar el stock mínimo.");
            }

            if (!_validacionesBLL.esDecimal(stockMinimo))
            {
                throw new ArgumentException("El stock mínimo debe ser un valor numérico decimal válido.");
            }

            if (activo == null || activo.Trim() == "")
            {
                throw new ArgumentException("Debe indicar si es un insumo activo.");
            }
        }

        public bool AgregarInsumo(Insumo insumo)
        {
            try
            {
                return _insumoBLL.AgregarInsumo(insumo);
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
                return _insumoBLL.EditarInsumo(insumo);
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
