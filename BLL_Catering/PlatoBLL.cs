using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;
using DAL_Catering;
using NLog;
using System.Data.SqlClient;
using System.Data;
using DTO_Catering;
using System.Globalization;
using System.ComponentModel;
using System.IO;

namespace BLL_Catering
{
    public class PlatoBLL
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly PlatoDAL _platoDAL;
        private readonly ValidacionesBLL _validaciones;
        public PlatoBLL() {
            _platoDAL = new PlatoDAL();
            _validaciones = new ValidacionesBLL();
        }


        public List<Plato> BuscarPlatos(string nombre, string tipo, string activo)
        {
            try
            {
                StringBuilder consulta = new StringBuilder(@"SELECT id_plato, nombre, tipo_plato, fecha_baja FROM plato");
                List<SqlParameter> parametros = new List<SqlParameter>();
                List<string> condiciones = new List<string>();

                if (!(nombre == null || nombre.Trim() == ""))
                {
                    condiciones.Add("nombre LIKE @Nombre");
                    parametros.Add(new SqlParameter("@Nombre", "%" + nombre + "%"));
                }

                if (!(tipo == null || tipo.Trim() == ""))
                {
                    condiciones.Add("tipo_plato LIKE @Tipo");
                    parametros.Add(new SqlParameter("@Tipo", "%" + tipo + "%"));
                }

                if (!(activo == null || activo.Trim() == ""))
                {
                    if (activo == "Si")
                        condiciones.Add("fecha_baja IS NULL");
                    else if (activo == "No")
                        condiciones.Add("fecha_baja IS NOT NULL");
                }

                if (condiciones.Any())
                {
                    consulta.Append(" WHERE " + string.Join(" AND ", condiciones));
                }

                return _platoDAL.BuscarPlatos(consulta.ToString(), parametros);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al filtrar platos en BLL");
                throw ex;
            }
           

        }


        public List<Plato> BuscarPlatosPorMenu(int idMenu)
        {
            try
            {
                return _platoDAL.BuscarPlatosPorMenu(idMenu);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al filtrar platos en BLL");
                throw ex;
            }

        }


        public bool EditarPlato(Plato plato)
        {
            try {
                ValidarDatosPlato(plato);
                return _platoDAL.EditarPlato(plato.Nombre, plato.TipoPlato, plato.FechaBaja, plato.IdPlato) <= 0 ? false : true;
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "Error de validación al agregar plato en BLL");
                throw ex;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar plato en BLL");
                throw ex;
            }
        }

        public bool AgregarPlato(Plato plato)
        {
            try
            {
                ValidarDatosPlato(plato);
                plato.IdPlato = _platoDAL.AgregarPlato(plato.Nombre, plato.TipoPlato, plato.FechaBaja);
                return plato.IdPlato <=0 ? false : true;
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "Error de validación al agregar plato en BLL");
                throw ex;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar plato en BLL");
                throw ex;
            }
        }

        private void ValidarDatosPlato(Plato plato)
        {
            if(plato == null)
            {
                throw new ArgumentException("El plato no puede ser nulo.");
            }
            if (string.IsNullOrWhiteSpace(plato.Nombre))
            {
                throw new ArgumentException("El nombre del plato no puede estar vacío.");
            }
            if(string.IsNullOrWhiteSpace(plato.TipoPlato))
            {
                throw new ArgumentException("El tipo de plato no puede estar vacío.");
            }
        }


        public bool EliminarIngredientePlato(InsumoPlatoDTO insumo)
        {
            try
            {
                return _platoDAL.EliminarIngrediente(insumo.IdInsumoPlato);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al eliminar plato en BLL");
                throw ex;
            }
        }


        public bool EditarIngredientePlato(int id_plato, InsumoPlatoDTO insumo)
        {
            try
            {
                return _platoDAL.EditarIngrediente(id_plato, insumo.IdInsumo, insumo.CantidadNecesaria, insumo.IdInsumoPlato);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar plato en BLL");
                throw ex;
            }
        }


        public bool AgregarIngredientePlato(int id_plato, InsumoPlatoDTO insumo)
        {
            try
            {
                return _platoDAL.AgregarIngrediente(id_plato, insumo.IdInsumo, insumo.CantidadNecesaria);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al agregar plato en BLL");
                throw ex;
            }
        }

    
    }
}
