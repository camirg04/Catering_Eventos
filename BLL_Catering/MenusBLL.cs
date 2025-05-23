using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Catering;
using Entity_Catering;


namespace BLL_Catering
{

    
    public class MenusBLL
    {

        private readonly MenuDAL _menuDAL;



        public MenusBLL()
        {
            _menuDAL = new MenuDAL();
        }


        public List<Menu> ListarMenus()
        {
            DAL_Catering.MenuDAL dalMenu = new DAL_Catering.MenuDAL();

            List<Entity_Catering.Menu> menus = dalMenu.Listar();

            return menus;

        }


    }
}
