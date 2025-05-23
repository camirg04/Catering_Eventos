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

                unEvento.IdEvento = int.Parse(fila["id_evento"].ToString());
                unEvento.Cliente.Id = int.Parse(fila["id_cliente"].ToString());
                unEvento.Menu.IdMenu = int.Parse(fila["id_menu"].ToString());
                unEvento.FechaEvento = DateTime.Parse(fila["fecha_evento"].ToString());
                unEvento.DescuentoAplicado = Decimal.Parse(fila["descuento_aplicado"].ToString());
                unEvento.Direccion = fila["direccion"].ToString();
                unEvento.Localidad = fila["localidad"].ToString();
                unEvento.EstadoEvento = fila["estado_evento"].ToString();
                unEvento.CantidadPersonas = int.Parse(fila["cantidad_personas"].ToString());
                unEvento.TotalEstimado = Decimal.Parse(fila["total_estimado"].ToString());
             //   unEvento.Pago = int.Parse(fila["evento_pago"].ToString());
                unEvento.UsuarioVenta.IdUsuario = int.Parse(fila["id_usuario_venta"].ToString());

                eventos.Add(unEvento);

            }

            return eventos;

        }


    }
}
