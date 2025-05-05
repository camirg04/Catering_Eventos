using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Entity_Catering;
using System.Globalization;
using System.Data;

namespace DAL_Catering
{
    public class InsumoDAL
    {
        private readonly Conexion conexion;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public InsumoDAL()
        {
            conexion = new Conexion();
        }

        public List<Insumo> ObtenerInsumosActivos()
        {
            try
            {
                string consulta = @"select id_insumo,nombre, unidad_medida, perecedero,stock_minimo from insumo where fecha_baja is null";
                DataTable resultado = conexion.LeerPorComando(consulta);

                if (resultado?.Rows.Count == 0)
                    return null;
                List<Insumo> listaInsumos = new List<Insumo>();

                foreach (DataRow row in resultado.Rows)
                {
                    Insumo insumo = new Insumo();
                    insumo.IdInsumo = Convert.ToInt32(row["id_insumo"]);
                    insumo.Nombre = row["nombre"].ToString();
                    insumo.UnidadMedida = row["unidad_medida"].ToString();
                    insumo.Perecedero = Convert.ToBoolean(row["perecedero"]);
                    insumo.StockMinimo = Convert.ToDecimal(row["stock_minimo"]);
                    listaInsumos.Add(insumo);
                }

                return listaInsumos;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al obtener insumos");
                throw ex;
            }
        }

    }
}
