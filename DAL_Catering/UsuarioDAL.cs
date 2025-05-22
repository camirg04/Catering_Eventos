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
    public class UsuarioDAL
    {
        private readonly Conexion conexion;
        public UsuarioDAL(){
            conexion = new Conexion();
        }
        public List<Usuario> Listar()
        {

           // Conexion conexion = new Conexion();

            List<Usuario> empleados = new List<Usuario>();
            DataTable dt = conexion.LeerPorStoreProcedure("sp_todoEmpleados2");


            foreach (DataRow fila in dt.Rows)
            {

                Usuario unEmpleado = new Usuario();

                unEmpleado.IdUsuario = int.Parse(fila["ID"].ToString());
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
