using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;
using NLog;

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

    }
}
