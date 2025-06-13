using Entity_Catering;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<Evento> GetEventoByIdCliente(int id)
        {
            List<Entity_Catering.Evento> eventos = new List<Entity_Catering.Evento>();
            //Parametros para el sql
            SqlParameter[] valores = {
                new SqlParameter("id_cliente", id)
            };

            DataTable dt = conexion.LeerPorStoreProcedure("sp_getEventoByCliente", valores);

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
    }
}
