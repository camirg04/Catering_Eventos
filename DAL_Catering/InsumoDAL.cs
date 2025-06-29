using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Entity_Catering;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;

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


        public List<Insumo> BuscarInsumos(string nombre, string activos)
        {
            try
            {
                var insumos = new List<Insumo>();

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@activos", SqlDbType.TinyInt, 100) { Value = activos == "" || activos == null ? DBNull.Value : (object)(activos == "Si" ? 1 : 0)  },
                    new SqlParameter("@nombre", SqlDbType.VarChar, 100) { Value = nombre }
                };

                var dt = conexion.LeerPorStoreProcedure("sp_listar_insumos", parametros);



                foreach (DataRow row in dt.Rows)
                {
                    var insumo = new Insumo();
                    insumo.IdInsumo = Convert.ToInt32(row["id_insumo"]);
                    insumo.Nombre = row["nombre"].ToString();
                    insumo.UnidadMedida = row["unidad_medida"].ToString();
                    insumo.Perecedero = Convert.ToBoolean(row["perecedero"]);
                    insumo.StockMinimo = Convert.ToDecimal(row["stock_minimo"]);
                    insumo.FechaBaja = row["fecha_baja"] as DateTime?;
                    insumos.Add(insumo);
                }

                return insumos;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al buscar insumos en DAL");
                throw;
            }
        }


        public int AgregarInsumo(Insumo insumo)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", SqlDbType.NVarChar, 100) { Value = insumo.Nombre },
                    new SqlParameter("@unidad_medida", SqlDbType.NVarChar, 50) { Value = insumo.UnidadMedida },
                    new SqlParameter("@perecedero", SqlDbType.NVarChar, 10) { Value = insumo.Perecedero },
                    new SqlParameter("@stock_minimo", SqlDbType.Decimal) { Value = insumo.StockMinimo },
                    new SqlParameter("@fecha_baja", SqlDbType.Date)
                    {
                        Value = insumo.FechaBaja.HasValue ? (object)insumo.FechaBaja.Value : DBNull.Value
                    }
                };

                DataTable dt = conexion.LeerPorStoreProcedure("sp_agregar_insumo", parametros);

                string mensaje = "";

                if (dt != null && dt.Rows.Count > 0)
                {
                    mensaje = dt.Rows[0]["mensaje"].ToString();
                }

                if (mensaje != "OK")
                {
                    throw new ArgumentException(mensaje);
                }

                return 1;
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "Error al agregar menu a plato en DAL ");
                throw;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al agregar menu a plato en DAL ");
                throw;
            }
        }


        public int EditarInsumo(Insumo insumo)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", SqlDbType.NVarChar, 100) { Value = insumo.Nombre },
                    new SqlParameter("@unidad_medida", SqlDbType.NVarChar, 50) { Value = insumo.UnidadMedida },
                    new SqlParameter("@perecedero", SqlDbType.NVarChar, 10) { Value = insumo.Perecedero },
                    new SqlParameter("@stock_minimo", SqlDbType.Decimal) { Value = insumo.StockMinimo },
                    new SqlParameter("@id_insumo", SqlDbType.Int) { Value = insumo.IdInsumo },
                    new SqlParameter("@fecha_baja", SqlDbType.Date)
                    {
                        Value = insumo.FechaBaja.HasValue ? (object)insumo.FechaBaja.Value : DBNull.Value
                    }
                };

                DataTable dt = conexion.LeerPorStoreProcedure("sp_editar_insumo", parametros);

                string mensaje = "";

                if (dt != null && dt.Rows.Count > 0)
                {
                    mensaje = dt.Rows[0]["mensaje"].ToString();
                }

                if (mensaje != "OK")
                {
                    throw new ArgumentException(mensaje);
                }

                return 1;
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "Error al editar menu a plato en DAL ");
                throw;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar menu a plato en DAL ");
                throw;
            }
        }

    }
}
