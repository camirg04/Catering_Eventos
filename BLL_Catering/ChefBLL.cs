using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Catering;
using Entity_Catering;
using NLog;

namespace BLL_Catering
{
    public class ChefBLL
    {
        private readonly PlatoBLL _platoBLL;
        private readonly ValidacionesBLL _validaciones;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public ChefBLL() {
            _platoBLL = new PlatoBLL();
            _validaciones = new ValidacionesBLL();
        }



        public List<Plato> BuscarPlatos(string nombre, string tipo, string activo)
        {
            try
            {
                return _platoBLL.BuscarPlatos(nombre, tipo, activo);
            }
            catch (Exception e) {
                logger.Error(e.ToString());
                throw;
            }            
        }

        public string sinPlatoSeleccionado(InsumoPlatoDTO insumoSeleccionado)
        {
            if (insumoSeleccionado == null)
            {
                return "Seleccione un insumo para editar";
            }

            return null;
        }

        public string cantidadInvalida(string cantidad)
        {
            bool esDecimal = _validaciones.esDecimal(cantidad);
            if (!esDecimal)
            {
                return "Formato numero incorrecto";
            }
            return null;
        }

        public string platoDuplicado(int idInsumo, BindingList<InsumoPlatoDTO> listInsumos)
        {
            int mismoInsumo = 0;
            foreach (InsumoPlatoDTO insumo in listInsumos)
            {
                if (insumo.IdInsumo == idInsumo)
                {
                    mismoInsumo++;
                }
            }

            if (mismoInsumo >= 1)
            {
                return "No se puede duplicar el insumo en el plato";
            }
            return null;
        }

        public void editarInsumo(InsumoPlatoDTO insumo, List<Insumo> insumos, int idInsumo, string cantidad)
        {
            Insumo ins = insumos.Find(_insumo => _insumo.IdInsumo == idInsumo);
            insumo.CantidadNecesaria = Decimal.Parse(cantidad, new CultureInfo("es-ES"));
            insumo.IdInsumo = ins.IdInsumo;
            insumo.NombreInsumo = ins.Nombre;
            insumo.UnidadMedida = ins.UnidadMedida;
        }

        public bool guardarCambiosPlato(string accion, Plato plato, List<InsumoPlatoDTO> platosAgregar, List<InsumoPlatoDTO> platosEditar, List<InsumoPlatoDTO> platosEliminar)
        {
            try
            {
                return _platoBLL.guardarCambiosPlato(accion,plato,platosAgregar,platosEditar,platosEliminar);
            }
            catch (Exception e)
            {
                logger.Error(e.ToString());
                throw;
            }
        }

    }
}
