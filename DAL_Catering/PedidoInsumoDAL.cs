using Entity_Catering;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Catering
{
    public class PedidoInsumoDAL
    {

        private readonly Conexion conexion;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public PedidoInsumoDAL()
        {
            conexion = new Conexion();
        }

        public List<PedidoInsumo> ObtenerPedidoInsumo()
        {
            try
            {
                return ListarPedidos(0, null, null);
            }
            catch (Exception ex) {
                throw;
            }
        }

        public List<PedidoInsumo> ObtenerPedidoInsumo(int idInsumo, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            try
            {
                return ListarPedidos(idInsumo, fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        private List<PedidoInsumo> ListarPedidos(int idInsumo, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            try
            {
                List<PedidoInsumo> pedidos = new List<PedidoInsumo>();
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id_insumo", SqlDbType.Int) {Value = idInsumo == 0 ? DBNull.Value : (object)idInsumo },
                    new SqlParameter("@fecha_desde", SqlDbType.Date) {Value = fechaDesde == null ? DBNull.Value : (object)fechaDesde },
                    new SqlParameter("@fecha_hasta", SqlDbType.Date) {Value = fechaHasta == null ? DBNull.Value : (object)fechaHasta }
                };

                var dt = conexion.LeerPorStoreProcedure("ObtenerPedidosDeInsumos", parametros);

                foreach (DataRow fila in dt.Rows)
                {
                    PedidoInsumo pedido = new PedidoInsumo();
                    pedido.Insumo = new Insumo
                    {
                        IdInsumo = int.Parse(fila["id_insumo"].ToString()),
                        Nombre = fila["nombre"].ToString(),
                        UnidadMedida = fila["unidad_medida"].ToString()
                    };

                    pedido.UsuarioPedido = new Usuario
                    {
                        IdUsuario = int.Parse(fila["id_usuario"].ToString()),
                        Nombre = fila["nombre"].ToString(),
                        Apellido = fila["apellido"].ToString()

                    };
                    pedido.IdPedidoInsumo = int.Parse(fila["id_pedido_insumo"].ToString());
                    pedido.Cantidad = Decimal.Parse(fila["cantidad"].ToString());
                    pedido.FechaPedido = DateTime.Parse(fila["fecha_pedido"].ToString());
                    pedido.EstadoPedido = fila["estado_pedido"].ToString();
                    pedidos.Add(pedido);
                }

                return pedidos;
            }
            catch (Exception ex) { 
                logger.Error(ex);
                throw;
            }
                
        }

        public bool UpdatePedidoInsumoBLL(int idInsumo, int idPedidoInsumo, DateTime fechaPedidoInsumo, string entregado, Decimal cantidad,int costo)

        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("id_insumo", idInsumo) ,
                    new SqlParameter("id_pedidoInsumo", idPedidoInsumo) ,
                    new SqlParameter("cantidad", cantidad) ,
                    new SqlParameter("fecha_pedido", fechaPedidoInsumo) ,
                    new SqlParameter("estado_pedido", entregado) ,
                    new SqlParameter("costo_unitario", costo)
                };

                int resp  = conexion.EscribirPorStoreProcedure("UpdatePedidosDeInsumos", parametros);

                if (resp <=0)
                {
                    throw new Exception("No se pudo actualizar el pedido de insumo.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return true;

        }

        public bool AddPedidoInsumoDAL(int idInsumo, DateTime fecha_pedido, string estado, Decimal cantidad, int idUsuario)
        {

            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("id_insumo", idInsumo) ,
                    new SqlParameter("cantidad", cantidad) ,
                    new SqlParameter("fecha_pedido", fecha_pedido) ,
                    new SqlParameter("estado_pedido", estado) ,
                    new SqlParameter("id_usuario_pedido", idUsuario)
                };

                conexion.EscribirPorStoreProcedure("addPedidoInsumo", parametros);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

            return true;
        }
    }
}
