using Entity_Catering;
using NLog;
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
    public class EventoDAL
    {

        private readonly Conexion conexion;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public EventoDAL()
        {
            conexion = new Conexion();
        }

        public List<Entity_Catering.Evento> Listar()
        {
            List<Entity_Catering.Evento> eventos = new List<Entity_Catering.Evento>();

            DataTable dt = conexion.LeerPorStoreProcedure("sp_todoEventos");

            foreach (DataRow fila in dt.Rows)
            {
                Entity_Catering.Evento unEvento = new Entity_Catering.Evento();  

                unEvento.Id = int.Parse(fila["id_evento"].ToString());
                unEvento.IdCliente = int.Parse(fila["id_cliente"].ToString());
                unEvento.IdMenu = int.Parse(fila["id_menu"].ToString());
                unEvento.Fecha = DateTime.Parse(fila["fecha_evento"].ToString());
                unEvento.DescuentoAplicado = float.Parse(fila["descuento_aplicado"].ToString());
                unEvento.Direccion = fila["direccion"].ToString();
                unEvento.Localidad = fila["localidad"].ToString();
                unEvento.Estado = fila["estado_evento"].ToString();
                unEvento.CantidadPersonas = int.Parse(fila["cantidad_personas"].ToString());
                unEvento.Total = float.Parse(fila["total_estimado"].ToString());
                //unEvento.Pago = int.Parse(fila["evento_pago"].ToString());
                unEvento.IdUsuarioVenta = int.Parse(fila["id_usuario_venta"].ToString());
                eventos.Add(unEvento);

            }

            return eventos;

        }

        public List<Entity_Catering.Evento> OneEvento(int id_evento)
        {
            List<Entity_Catering.Evento> eventos = new List<Entity_Catering.Evento>();
            //Parametros para el sql
            SqlParameter[] valores = {
                new SqlParameter("id_evento", id_evento)
            };

            DataTable dt = conexion.LeerPorStoreProcedure("sp_onlyEvento", valores);

            foreach (DataRow fila in dt.Rows)
            {
                Entity_Catering.Evento unEvento = new Entity_Catering.Evento();

                unEvento.Id = int.Parse(fila["id_evento"].ToString());
                unEvento.IdCliente = int.Parse(fila["id_cliente"].ToString());
                unEvento.IdMenu = int.Parse(fila["id_menu"].ToString());
                unEvento.Fecha = DateTime.Parse(fila["fecha_evento"].ToString());
                unEvento.DescuentoAplicado = float.Parse(fila["descuento_aplicado"].ToString());
                unEvento.Direccion = fila["direccion"].ToString();
                unEvento.Localidad = fila["localidad"].ToString();
                unEvento.Estado = fila["estado_evento"].ToString();
                unEvento.CantidadPersonas = int.Parse(fila["cantidad_personas"].ToString());
                unEvento.Total = float.Parse(fila["total_estimado"].ToString());
                //unEvento.Pago = int.Parse(fila["evento_pago"].ToString());
                unEvento.IdUsuarioVenta = int.Parse(fila["id_usuario_venta"].ToString());

                eventos.Add(unEvento);

            }

            return eventos;

        }


        public Boolean AddEvento(Entity_Catering.Evento creaEvento)
        {
            SqlParameter[] valores = {
                //new SqlParameter("id_evento", creaEvento.Id),
                new SqlParameter("id_cliente", creaEvento.IdCliente),
                new SqlParameter("id_menu", creaEvento.IdMenu ),
                new SqlParameter("fecha_evento", creaEvento.Fecha),
                new SqlParameter("descuento_aplicado", creaEvento.DescuentoAplicado),
                new SqlParameter("direccion", creaEvento.Direccion ),
                new SqlParameter("localidad", creaEvento.Localidad ),
                new SqlParameter("estado_evento", creaEvento.Estado ),
                new SqlParameter("cantidad_personas", creaEvento.CantidadPersonas ),
                new SqlParameter("total_estimado",creaEvento.Total ),
                new SqlParameter("id_usuario_venta", creaEvento.IdUsuarioVenta),
                new SqlParameter("evento_pago", creaEvento.Pago)

            };

            try
            {
                // Ejecutar consulta
                int filasAfectadas = conexion.EscribirPorStoreProcedure("sp_addEvento", valores);
                return true;
            }
            catch (Exception ex)
            {
                //logger.Error("Tuvimos un error al guardar"+ex.Message);
                Console.WriteLine(ex.ToString());
                return false;
            }

            //return false;
        }
        public Boolean UpdateEvento(Entity_Catering.Evento UpdateEvento)
        {

            SqlParameter[] valores = {
                new SqlParameter("id_evento", UpdateEvento.Id),
                new SqlParameter("id_cliente", UpdateEvento.IdCliente),
                new SqlParameter("id_menu", UpdateEvento.IdMenu ),
                new SqlParameter("fecha_evento", UpdateEvento.Fecha),
                new SqlParameter("descuento_aplicado", UpdateEvento.DescuentoAplicado),
                new SqlParameter("direccion", UpdateEvento.Direccion ),
                new SqlParameter("localidad", UpdateEvento.Localidad ),
                new SqlParameter("estado_evento", UpdateEvento.Estado ),
                new SqlParameter("cantidad_personas", UpdateEvento.CantidadPersonas ),
                new SqlParameter("total_estimado",UpdateEvento.Total ),
                new SqlParameter("id_usuario_venta", UpdateEvento.IdUsuarioVenta),
                new SqlParameter("evento_pago", UpdateEvento.Pago)

            };

            try
            {
                // Ejecutar consulta
                int filasAfectadas = conexion.EscribirPorStoreProcedure("sp_updateEvento", valores);
                return true;
            }
            catch (Exception ex)
            {
                //logger.Error("Tuvimos un error al guardar"+ex.Message);
                Console.WriteLine(ex.ToString());
                return false;
            }

            //return false;
        }

        public List<EventoEntity> BuscarEventoPorFechaYEstado(DateTime fechaDesde, DateTime fechaHasta, string estado)
        {
            try
            {
                var lista = new List<EventoEntity>();
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@fecha_desde", SqlDbType.Date, 100) { Value =  fechaDesde},
                new SqlParameter("@fecha_hasta", SqlDbType.Date, 100) { Value = fechaHasta },
                new SqlParameter("@estado_evento", SqlDbType.VarChar, 50) { Value = estado }
                };
                var dt = conexion.LeerPorStoreProcedure("ObtenerEventosPorEstadoYFechas", parametros);

                foreach (DataRow fila in dt.Rows)
                {
                    var evento = new EventoEntity();

                    evento.EstadoEvento = fila["estado_evento"].ToString();
                    evento.IdEvento = Convert.ToInt32(fila["id_evento"]);

                    evento.FechaEvento = fila["fecha_evento"] != DBNull.Value
                        ? DateTime.Parse(fila["fecha_evento"].ToString())
                        : DateTime.MinValue;

                    evento.DescuentoAplicado = fila["descuento_aplicado"] != DBNull.Value ? Decimal.Parse(fila["descuento_aplicado"].ToString()) : 0;

                    evento.Direccion = fila["direccion"].ToString();
                    evento.Localidad = fila["localidad"].ToString();

                    evento.CantidadPersonas = fila["cantidad_personas"] != DBNull.Value ? int.Parse(fila["cantidad_personas"].ToString()) : 0;

                    evento.TotalEstimado = fila["total_estimado"] != DBNull.Value ? Decimal.Parse(fila["total_estimado"].ToString()) : 0;

                    evento.EventoPago = fila["evento_pago"] != DBNull.Value
                        ? bool.Parse(fila["evento_pago"].ToString())
                        : false;

                    evento.UsuarioVenta = new Vendedor();
                    evento.UsuarioVenta.IdUsuario = fila["id_usuario_venta"] != DBNull.Value
                        ? int.Parse(fila["id_usuario_venta"].ToString())
                        : 0;

                    evento.UsuarioVenta.Nombre = fila["nombre_vendedor"].ToString();
                    evento.UsuarioVenta.Apellido = fila["apellido_vendedor"].ToString();

                    evento.Cliente = new Cliente();
                    evento.Cliente.Id = fila["id_cliente"] != DBNull.Value
                        ? int.Parse(fila["id_cliente"].ToString())
                        : 0;

                    evento.Cliente.Nombre = fila["nombre_cliente"].ToString();
                    evento.Cliente.Apellido = fila["apellido_cliente"].ToString();

                    evento.Menu = new Menus();
                    evento.Menu.IdMenu = fila["id_menu"] != DBNull.Value
                        ? int.Parse(fila["id_menu"].ToString())
                        : 0;

                    evento.Menu.Nombre = fila["nombre_menu"].ToString();

                    lista.Add(evento);
                }

                return lista;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
        }


        public int ActualizarEstadoEvento(int idEvento, string nuevoEstado)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
            new SqlParameter("@id_evento", SqlDbType.Int) { Value = idEvento },
            new SqlParameter("@estado", SqlDbType.NVarChar, 50) { Value = nuevoEstado }
                };

                return conexion.EscribirPorStoreProcedure("sp_ActualizarEstadoEvento", parametros);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al actualizar el estado del evento");
                throw;
            }
        }

    }
}
