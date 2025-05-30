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
    public class MenuDAL
    {

        private readonly Conexion conexion;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public MenuDAL()
        {

            conexion = new Conexion();

        }

        public List<Menus> Listar()
        {
            List<Menus> menu = new List<Menus>();
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


        public List<Menus> Listar(string nombre, Decimal? precio, string comparador, bool soloActivos)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@nombre", SqlDbType.VarChar, 100) { Value = nombre },
                new SqlParameter("@precio", SqlDbType.Decimal, 100) { Value = precio },
                new SqlParameter("@comparador", SqlDbType.VarChar, 100) { Value = comparador },
                new SqlParameter("@soloActivos", SqlDbType.Bit, 100) { Value = soloActivos }
                };
                DataTable dt = conexion.LeerPorStoreProcedure("sp_ObtenerMenusFiltrados", parametros);

                var menuList = new List<Menus>();
                foreach (DataRow fila in dt.Rows)
                {
                    var menuItem = new Menus();
                    menuItem.IdMenu = int.Parse(fila["id_menu"].ToString());
                    menuItem.Nombre = fila["nombre"].ToString();
                    menuItem.PrecioPorPersona = float.Parse(fila["precio_x_persona"].ToString());
                    if (fila["fecha_baja"] != DBNull.Value)
                    {
                        menuItem.FechaDeBaja = DateTime.Parse(fila["fecha_baja"].ToString());
                    }
                    else
                    {
                        menuItem.FechaDeBaja = null;
                    }
                        var platoDal = new PlatoDAL();
                    menuItem.Platos = platoDal.obtenerPlatosPorMenu(menuItem.IdMenu);
                    menuList.Add(menuItem);
                }

                return menuList;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al obtener menu en DAL");
                throw;

            }
        }
    }
}
