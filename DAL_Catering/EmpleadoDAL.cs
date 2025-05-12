using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity_Catering;
using System.Data.SqlClient;


namespace DAL_Catering
{
    public class EmpleadoDAL
    {
        private readonly Conexion conexion;
        public EmpleadoDAL(){
            conexion = new Conexion();
        }
        public List<Entity_Catering.Empleado> Listar()
        {

           // Conexion conexion = new Conexion();

            List<Entity_Catering.Empleado> empleados = new List<Entity_Catering.Empleado>();
            DataTable dt = conexion.LeerPorStoreProcedure("sp_todoEmpleados2");


            foreach (DataRow fila in dt.Rows)
            {

                Entity_Catering.Empleado unEmpleado = new Entity_Catering.Empleado();

                unEmpleado.IdEmpleado = int.Parse(fila["ID"].ToString());
                unEmpleado.DNI = fila["DNI"].ToString();
                unEmpleado.Nombre = fila["Nombre"].ToString();
                unEmpleado.Apellido = fila["Apellido"].ToString();
                unEmpleado.Domicilio = fila["Domicilio, calle y numero"].ToString();
                unEmpleado.Telefono = fila["Telefono"].ToString();

               
                

                empleados.Add(unEmpleado);

                
            }

            return empleados;
        }


    }
}
