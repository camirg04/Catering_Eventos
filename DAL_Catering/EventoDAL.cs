using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Catering
{
    public class EventoDAL
    {

        private readonly Conexion conexion;

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
             //   unEvento.Pago = int.Parse(fila["evento_pago"].ToString());
                unEvento.IdUsuarioVenta = int.Parse(fila["id_usuario_venta"].ToString());

                eventos.Add(unEvento);

            }

            return eventos;

        }


    }
}
