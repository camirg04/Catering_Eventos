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

        public List<Entity_Catering.Menus> Listar()
        {
            List<Entity_Catering.Menus> menu = new List<Entity_Catering.Menus>();
            DataTable dt = conexion.LeerPorStoreProcedure("sp_menusDisponibles");

            foreach (DataRow fila in dt.Rows)
            {

                Entity_Catering.Menus unMenu = new Entity_Catering.Menus();
                unMenu.IdMenu = int.Parse(fila["id_menu"].ToString());
                unMenu.Nombre = fila["nombre"].ToString();
                unMenu.PrecioPorPersona = Decimal.Parse(fila["precio_x_persona"].ToString());


                menu.Add(unMenu);

            }

            return menu;

        }




        public List<Menus> BuscarMenus(string nombre, string activos)
        {
            try
            {
                var menus = new List<Menus>();

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@activos", SqlDbType.TinyInt, 100) { Value = activos == "" || activos == null ? DBNull.Value : (object)(activos == "Si" ? 1 : 0)  },
                    new SqlParameter("@nombre", SqlDbType.VarChar, 100) { Value = nombre }
                };
                var dt = conexion.LeerPorStoreProcedure("BuscarMenu", parametros);



                foreach (DataRow row in dt.Rows)
                {
                    var menu = new Menus();
                    menu.IdMenu = Convert.ToInt32(row["id_menu"]);
                    menu.Nombre = row["nombre"].ToString();
                    menu.PrecioPorPersona = Convert.ToDecimal(row["precio_x_persona"]);
                    menu.FechaDeBaja = row["fecha_baja"] as DateTime?;

                    var platos = new List<Plato>();
                    parametros = new SqlParameter[]
                    {
                    new SqlParameter("@id_menu", SqlDbType.Int, 100) { Value = menu.IdMenu }
                    };
                    var dtPlatos = conexion.LeerPorStoreProcedure("ListarPlatosPorMenu", parametros);

                    foreach (DataRow rowPlato in dtPlatos.Rows)
                    {
                        Plato plato = new Plato();
                        plato.IdPlato = Convert.ToInt32(rowPlato["id_plato"]);
                        plato.Nombre = rowPlato["nombre_plato"].ToString();
                        plato.TipoPlato = rowPlato["tipo_plato"].ToString();
                        plato.FechaBaja = rowPlato["fecha_baja"] as DateTime?;
                        platos.Add(plato);
                    }
                    menu.Platos = platos;
                    menus.Add(menu);
                }

                return menus;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al buscar menus en DAL");
                throw;
            }
        }


        public int CrearMenu(string nombre, Decimal precio, DateTime? fechaBaja)
        {
            try
            {
                // Crear parámetros
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@nombre", SqlDbType.VarChar, 100) { Value = nombre },
                new SqlParameter("@precio_x_persona", SqlDbType.Decimal, 100) { Value = precio },
                new SqlParameter("@fecha_baja", SqlDbType.Date, 100) { Value = fechaBaja ?? (object)DBNull.Value }
                };

                DataTable dt = conexion.LeerPorStoreProcedure("CrearMenu", parametros);

                int nuevoIdMenu = -1;

                if (dt != null && dt.Rows.Count > 0)
                {
                    nuevoIdMenu = Convert.ToInt32(dt.Rows[0]["id_menu"]);
                }

                return nuevoIdMenu;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al agregar menu a plato en DAL ");
                throw;
            }
        }

        public int EditarMenu(int idMenu,string nombre, Decimal precio, DateTime? fechaBaja)
        {
            try
            {
                // Crear parámetros
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@id_menu", SqlDbType.BigInt, 100) { Value = idMenu },
                new SqlParameter("@nombre", SqlDbType.VarChar, 100) { Value = nombre },
                new SqlParameter("@precio_x_persona", SqlDbType.Decimal, 100) { Value = precio },
                new SqlParameter("@fecha_baja", SqlDbType.Date, 100) { Value = fechaBaja ?? (object)DBNull.Value }
                };

                return conexion.EscribirPorStoreProcedure("EditarMenu", parametros);

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar menu a plato en DAL ");
                throw;
            }
        }


        public int AgregarPlatoMenu(int idMenu,int idPlato)
        {
            try
            {
                // Crear parámetros
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@id_plato", SqlDbType.Int, 100) { Value = idPlato },
                new SqlParameter("@id_menu", SqlDbType.Int, 100) { Value = idMenu }
                };

                DataTable dt = conexion.LeerPorStoreProcedure("AgregarPlatoMenu", parametros);

                string mensaje = "";

                if (dt != null && dt.Rows.Count > 0)
                {
                    mensaje  = dt.Rows[0]["mensaje"].ToString();
                }

                if(mensaje != "OK")
                {
                    throw new ArgumentException(mensaje);
                }

                return 1;
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "Error al agregar menu a plato en DAL ");
                throw;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al agregar menu a plato en DAL ");
                throw;
            }
        }


        public int EliminarPlatoMenu(int idMenu, int idPlato)
        {
            try
            {
                // Crear parámetros
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@id_plato", SqlDbType.Int, 100) { Value = idPlato },
                new SqlParameter("@id_menu", SqlDbType.Int, 100) { Value = idMenu }
                };

                DataTable dt = conexion.LeerPorStoreProcedure("EliminarPlatoMenu", parametros);

                string mensaje = "";

                if (dt != null && dt.Rows.Count > 0)
                {
                    mensaje = dt.Rows[0]["mensaje"].ToString();
                }

                if (mensaje != "OK")
                {
                    throw new ArgumentException(mensaje);
                }

                return 1;
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "Error al agregar menu a plato en DAL ");
                throw;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al agregar menu a plato en DAL ");
                throw;
            }
        }

    }
}
