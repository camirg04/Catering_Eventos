using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Catering;
using Entity_Catering;

namespace BLL_Catering
{
    public class UsuarioBLL
    {

        private readonly UsuarioDAL _empleadosDal;

        public UsuarioBLL() {
            _empleadosDal = new UsuarioDAL();
        }


        public List<Usuario> ListarEmpleados()
        {
            DAL_Catering.UsuarioDAL dalEmpleado = new DAL_Catering.UsuarioDAL();

            List<Usuario> empleados = dalEmpleado.Listar();

            List<Usuario> auxEmpleado = empleados;


            return auxEmpleado;
        }


    }
}
