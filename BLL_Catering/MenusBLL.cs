using System;
using System.Collections.Generic;
using System.Globalization;
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
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly MenuDAL _menuDAL;
        private readonly ValidacionesBLL _validaciones;

        public MenusBLL()
        {
            _menuDAL = new MenuDAL();
            _validaciones = new ValidacionesBLL();
        }


        public List<Menus> ListarMenus()
        {
           
            List<Entity_Catering.Menus> menus = _menuDAL.Listar();

            return menus;

        }


        public List<Menus> ListarMenus(string nombre, string precio,string operacion, string activo)
        {

            try
            {
                if(precio != null && !_validaciones.esDecimal(precio))
                {
                    throw new ValidacionException("El precio debe ser un número válido.");
                }

                nombre = nombre?.Trim() == "" ? null : nombre;
                Decimal? precioNumero;
                if(precio?.Trim() == "" || precio == null){
                    precioNumero = null;
                    operacion = null;
                }
                else
                {
                    precioNumero = Decimal.Parse(precio, new CultureInfo("es-ES"));
                }
                
                bool soloActivos = activo?.Trim() == "INACTIVO" ? false : true;

                return _menuDAL.Listar(nombre,precioNumero,operacion,soloActivos);

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error ListarMenus BLL");
                throw;
            }
           
        }




    }
}
