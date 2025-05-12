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


        public List<Menus> ListarMenus()
        {
            DAL_Catering.MenuDAL dalMenu = new DAL_Catering.MenuDAL();

            List<Entity_Catering.Menus> menus = dalMenu.Listar();

            return menus;

        }


    }
}
