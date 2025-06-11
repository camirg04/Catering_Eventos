using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;
using NLog;

namespace DAL_Catering
{
    public class AlertaStockDAL
    {
        private readonly Conexion conexion;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public AlertaStockDAL()
        {
            conexion = new Conexion();
        }

        public List<AlertaStock> FiltrarAlertas(DateTime fechaDesde, DateTime fechaHasta, string estado)
        {
            try
            {
                var alertas = new List<AlertaStock>();
                SqlParameter[] parametros = new SqlParameter[]
                    {
                new SqlParameter("@fechaDesde", SqlDbType.Date, 100) { Value = fechaDesde },
                new SqlParameter("@fechaHasta", SqlDbType.Date, 100) { Value = fechaHasta },
                new SqlParameter("@estado", SqlDbType.VarChar, 50) { Value = estado }
                    };
                var dt = conexion.LeerPorStoreProcedure("sp_filtrar_alertas_stock", parametros);

                foreach (DataRow fila in dt.Rows)
                {
                    var insumo = new Insumo();
                    insumo.Nombre = fila["nombre"].ToString();
                    var alerta = new AlertaStock
                    {
                        IdAlertaStock = int.Parse(fila["id_alerta"].ToString()),
                        Insumo = insumo,
                        EstadoAlerta = fila["estado_alerta"].ToString(),
                        FechaAlerta = DateTime.Parse(fila["fecha_alerta"].ToString())
                    };

                    alertas.Add(alerta);
                }
                return alertas;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al filtrar alertas de stock");
                throw;
            }
        }
    }
}
