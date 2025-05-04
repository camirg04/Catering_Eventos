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

namespace BLL_Catering
{
    public class PlatoBLL
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private PlatoDAL _platoDAL;
        public PlatoBLL() {
            _platoDAL = new PlatoDAL();
        }

        public List<Plato> BuscarPlatosActivos()
        {
            try
            {
                return _platoDAL.BuscarPlatosActivos();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al buscar platos activos en BLL");
                throw ex;
            }
        }

        public List<Plato> FiltrarPlatos(string nombre, string tipo, string activo)
        {
            try
            {
                StringBuilder consulta = new StringBuilder(@"SELECT id_plato, nombre, tipo_plato FROM plato");
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

                return _platoDAL.FiltrarPlatos(consulta.ToString(), parametros);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al filtrar platos en BLL");
                throw ex;
            }
           
        }
    }
}
