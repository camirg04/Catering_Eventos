using Entity_Catering;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Catering
{
    public class LoteInsumoDAL
    {
        private readonly Conexion conexion;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public LoteInsumoDAL()
        {
            conexion = new Conexion();
        }


        public List<LoteInsumo> ListarLotes()
        {
            try
            {
                var listaLotes = new List<LoteInsumo>();
                var dt = conexion.LeerPorStoreProcedure("ObtenerLotesDeInsumos");
                foreach (DataRow fila in dt.Rows)
                {
                    var loteInsumo = new LoteInsumo();
                    loteInsumo.IDLoteInsumo = int.Parse(fila["id_lote"].ToString());
                    loteInsumo.Insumo = new Insumo
                    {
                        IdInsumo = int.Parse(fila["id_insumo"].ToString()),
                        Nombre = fila["nombre"].ToString(),
                        UnidadMedida = fila["unidad_medida"].ToString()
                    };

                    loteInsumo.PedidoInsumo = new PedidoInsumo
                    {
                        IdPedidoInsumo = int.Parse(fila["id_pedido"].ToString())
                    };
                    loteInsumo.Cantidad = decimal.Parse(fila["cantidad"].ToString());
                    loteInsumo.CostoUnitario = decimal.Parse(fila["costo_unitario"].ToString());
                    loteInsumo.FechaIngreso = DateTime.Parse(fila["fecha_ingreso"].ToString());
                    loteInsumo.FechaVencimiento = fila["fecha_vencimiento"] == DBNull.Value ? (DateTime?)null : DateTime.Parse(fila["fecha_vencimiento"].ToString());

                    listaLotes.Add(loteInsumo);
                }
                return listaLotes;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al listar lotes de insumos perecederos");
                throw;
            }
        }

        public List<LoteInsumo> ListarLotesPerecederos(DateTime fechaDesde, DateTime fechaHasta)
        {
            try {
                var listaLotes = new List<LoteInsumo>();
                SqlParameter[] parametros = new SqlParameter[]
                    {
                new SqlParameter("@fechaDesde", SqlDbType.Date, 100) { Value = fechaDesde },
                new SqlParameter("@fechaHasta", SqlDbType.Date, 100) { Value = fechaHasta }
                    };
                var dt = conexion.LeerPorStoreProcedure("ObtenerLotesDeInsumosPerecederos", parametros);
                foreach (DataRow fila in dt.Rows)
                {
                    var loteInsumo = new LoteInsumo();
                    loteInsumo.IDLoteInsumo = int.Parse(fila["id_lote"].ToString());
                    loteInsumo.Insumo = new Insumo
                    {
                        IdInsumo = int.Parse(fila["id_insumo"].ToString()),
                        Nombre = fila["nombre"].ToString(),
                        UnidadMedida = fila["unidad_medida"].ToString()
                    };

                    loteInsumo.PedidoInsumo = new PedidoInsumo
                    {
                        IdPedidoInsumo = int.Parse(fila["id_pedido"].ToString())
                    };
                    loteInsumo.Cantidad = decimal.Parse(fila["cantidad"].ToString());
                    loteInsumo.CostoUnitario = decimal.Parse(fila["costo_unitario"].ToString());
                    loteInsumo.FechaIngreso = DateTime.Parse(fila["fecha_ingreso"].ToString());
                    loteInsumo.FechaVencimiento = fila["fecha_vencimiento"] == DBNull.Value ? (DateTime?)null : DateTime.Parse(fila["fecha_vencimiento"].ToString());

                    listaLotes.Add(loteInsumo);
                }
                return listaLotes;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al listar lotes de insumos perecederos");
                throw;
            }
        }

        public List<LoteInsumo> ListarLotesPorIdInsumo(int id_insumo)
        {
            try
            {
                var listaLotes = new List<LoteInsumo>();
                SqlParameter[] parametros = new SqlParameter[]
                    {
                new SqlParameter("@IdInsumo", SqlDbType.BigInt, 100) { Value = id_insumo }
                    };
                var dt = conexion.LeerPorStoreProcedure("sp_ObtenerLotesInsumoVigentes", parametros);

                foreach (DataRow fila in dt.Rows)
                {
                    var loteInsumo = new LoteInsumo();
                    loteInsumo.IDLoteInsumo = int.Parse(fila["id_lote"].ToString());
                    loteInsumo.Insumo = new Insumo();
                    loteInsumo.Insumo.IdInsumo = int.Parse(fila["id_insumo"].ToString());
                    loteInsumo.Cantidad = decimal.Parse(fila["cantidad"].ToString());
                    loteInsumo.CostoUnitario = decimal.Parse(fila["costo_unitario"].ToString());
                    loteInsumo.FechaIngreso = DateTime.Parse(fila["fecha_ingreso"].ToString());
                    loteInsumo.FechaVencimiento = fila["fecha_vencimiento"] == DBNull.Value ? (DateTime?)null : DateTime.Parse(fila["fecha_vencimiento"].ToString());

                    listaLotes.Add(loteInsumo);
                }
                return listaLotes;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al listar lotes de insumos");
                throw;
            }
        }

        public int ActualizarCantidadLote(int idLote, decimal cantidad)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
            new SqlParameter("@IdLote", SqlDbType.Int) { Value = idLote },
            new SqlParameter("@Cantidad", SqlDbType.Decimal)
            {
                Value = cantidad,
                Precision = 18,
                Scale = 2
            }
                };

                return conexion.EscribirPorStoreProcedure("ActualizarStockLote", parametros);
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Error al actualizar la cantidad del lote con ID {idLote}");
                throw;
            }
        }

        public List<LoteInsumo> BuscarLotePorId(int idInsumo, string fechaIngresoInicio, string fechaIngresoFin)
        {

            List<LoteInsumo> listaLotes = new List<LoteInsumo>();

            SqlParameter[] valores = {
                new SqlParameter("id_insumo", idInsumo),
                new SqlParameter("fecha_ingreso_inicio", fechaIngresoInicio),
                new SqlParameter("fecha_ingreso_fin", fechaIngresoFin)
            };
            var dt = conexion.LeerPorStoreProcedure("ObtenerLotesDeInsumosxId", valores);
            foreach (DataRow fila in dt.Rows)
            {
                var loteInsumo = new LoteInsumo();
                loteInsumo.IDLoteInsumo = int.Parse(fila["id_lote"].ToString());
                loteInsumo.Insumo = new Insumo
                {
                    IdInsumo = int.Parse(fila["id_insumo"].ToString()),
                    Nombre = fila["nombre"].ToString(),
                    UnidadMedida = fila["unidad_medida"].ToString()
                };

                loteInsumo.PedidoInsumo = new PedidoInsumo
                {
                    IdPedidoInsumo = int.Parse(fila["id_pedido"].ToString())
                };
                loteInsumo.Cantidad = decimal.Parse(fila["cantidad"].ToString());
                loteInsumo.CostoUnitario = decimal.Parse(fila["costo_unitario"].ToString());
                loteInsumo.FechaIngreso = DateTime.Parse(fila["fecha_ingreso"].ToString());
                loteInsumo.FechaVencimiento = fila["fecha_vencimiento"] == DBNull.Value ? (DateTime?)null : DateTime.Parse(fila["fecha_vencimiento"].ToString());

                listaLotes.Add(loteInsumo);
            }

            return listaLotes;
        }
    }

}


       

