using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Catering;
using Entity_Catering;

namespace BLL_Catering
{
    public class EmpleadosBLL
    {

        private readonly EmpleadoDAL _empleadosDal;

        public EmpleadosBLL() {
            _empleadosDal = new EmpleadoDAL();
        }


        public List<Empleado> ListarEmpleados()
        {
            DAL_Catering.EmpleadoDAL dalEmpleado = new DAL_Catering.EmpleadoDAL();

            List<Entity_Catering.Empleado> empleados = dalEmpleado.Listar();

            List<Entity_Catering.Empleado> auxEmpleado = empleados;


            return auxEmpleado;
        }


    }
}
