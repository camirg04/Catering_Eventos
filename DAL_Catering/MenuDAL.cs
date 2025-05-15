using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;

namespace DAL_Catering
{
    public class MenuDAL
    {

        private readonly Conexion conexion;

        public MenuDAL()
        {

            conexion = new Conexion();

        }

        public List<Entity_Catering.Menus> Listar()
        {
            List<Entity_Catering.Menus> menu = new List<Entity_Catering.Menus>();
            DataTable dt = conexion.LeerPorStoreProcedure("sp_menusDisponibles");

            foreach (DataRow fila in dt.Rows)
            {

                Entity_Catering.Menus unMenu = new Entity_Catering.Menus();
                unMenu.IdMenu = int.Parse(fila["id_menu"].ToString());
                unMenu.Nombre = fila["nombre"].ToString();
                unMenu.PrecioPorPersona = float.Parse(fila["precio_x_persona"].ToString());
                

                menu.Add(unMenu);

            }

            return menu;

        }






    }

 


}
