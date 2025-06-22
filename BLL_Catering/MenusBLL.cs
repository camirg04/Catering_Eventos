using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Catering;
using Entity_Catering;
using NLog;


namespace BLL_Catering
{

    
    public class MenusBLL
    {

        private readonly MenuDAL _menuDAL;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();



        public MenusBLL()
        {
            _menuDAL = new MenuDAL();
        }


        public List<Menus> ListarMenus()
        {
            DAL_Catering.MenuDAL dalMenu = new DAL_Catering.MenuDAL();

            List<Entity_Catering.Menus> menus = dalMenu.Listar();

            return menus;

        }


        public List<Menus> BuscarMenus(string nombre, string activos)
        {
            try
            {
                return _menuDAL.BuscarMenus(nombre, activos);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al buscar menus en BLL");
                throw;
            }
        }

        public int CrearMenu(string nombre, Decimal precio, DateTime? fechaBaja)
        {
            try
            {
                ValidarDatosMenu(nombre, precio);
                return _menuDAL.CrearMenu(nombre, precio, fechaBaja);
            }
            catch (ArgumentException ex)
            {
                logger.Warn(ex, "Validación de datos fallida al agregar menu a plato en BLL");
                throw;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al agregar menu a plato en BLL ");
                throw;
            }
        }

        public int EditarMenu(int idMenu, string nombre, Decimal precio, DateTime? fechaBaja)
        {
            try
            {
                ValidarDatosMenu(nombre, precio);
                return _menuDAL.EditarMenu(idMenu, nombre, precio, fechaBaja);

            }
            catch (ArgumentException ex)
            {
                logger.Warn(ex, "Validación de datos fallida al editar menu a plato en BLL");
                throw; 
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar menu a plato en BLL ");
                throw;
            }
        }


        private void ValidarDatosMenu(string nombre, Decimal precio)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre del menú no puede estar vacío.");
            }
            if (precio == 0)
            {
                throw new ArgumentException("El precio no puede ser $0");
            }
        }

        public int AgregarPlatoMenu(int idMenu, int idPlato)
        {
            try
            {
                return _menuDAL.AgregarPlatoMenu(idMenu, idPlato);
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
                return _menuDAL.EliminarPlatoMenu(idMenu, idPlato);
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
