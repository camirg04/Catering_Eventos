using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;
using NLog;

namespace DAL_Catering
{
    public class PlatoDAL
    {
        Conexion conexion;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public PlatoDAL()
        {
            conexion = new Conexion();
        }

        public List<Plato> BuscarPlatosActivos()
        {
            try
            {
                // Consulta SQL parametrizada
                string consulta = @"select id_plato, nombre, tipo_plato from plato where fecha_baja is null";

                //obtener registros en datatable
                DataTable resultado = conexion.LeerPorComando(consulta);

                // Si no hay resultados, retornar null
                if (resultado?.Rows.Count == 0)
                    return null;

                List<Plato> listaPlatos = new List<Plato>();

                foreach (DataRow row in resultado.Rows)
                {
                    Plato plato = new Plato();
                    plato.IdPlato = Convert.ToInt32(row["id_plato"]);
                    plato.Nombre = row["nombre"].ToString();
                    plato.TipoPlato = row["tipo_plato"].ToString();

                    listaPlatos.Add(plato);
                }

                return listaPlatos;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al buscar platos activos en DAL");
                throw ex;
            }


        }
    }
}
