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

        public PedidoInsumoDAL()
        {
            conexion = new Conexion();
        }

        public List<PedidoInsumo> ObtenerPedidoInsumo()
        {
            List<PedidoInsumo> pedidos = new List<PedidoInsumo>();
            var dt = conexion.LeerPorStoreProcedure("ObtenerPedidosDeInsumos");

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
        public bool UpdatePedidoInsumoBLL(int idInsumo, int idPedidoInsumo, DateTime fechaPedidoInsumo, string entregado, Decimal cantidad,int costo)

        {
            //@id_pedidoInsumo bigint,
            //@id_insumo bigint,
            //@cantidad decimal(10, 2),
            //@fecha_pedido date,
            //@estado_pedido varchar(45)
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

                conexion.EscribirPorStoreProcedure("UpdatePedidosDeInsumos", parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return true;

        }

        public bool AddPedidoInsumoDAL(int idPedidoInsumo, int idInsumo, DateTime fecha_pedido, string estado, Decimal cantidad, int idUsuario)
        {

            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("id_pedido_insumo", idPedidoInsumo) ,
                    new SqlParameter("id_insumo", idInsumo) ,
                    new SqlParameter("cantidad", cantidad) ,
                    new SqlParameter("fecha_pedido", fecha_pedido) ,
                    new SqlParameter("estado_pedido", estado) ,
                    new SqlParameter("id_usuario_pedido", idUsuario)
                };

                conexion.EscribirPorStoreProcedure("AddPedidosDeInsumos", parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return true;
        }
    }
}
