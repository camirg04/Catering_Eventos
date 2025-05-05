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
    public class PlatoDAL
    {
        private readonly Conexion conexion;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public PlatoDAL()
        {
            conexion = new Conexion();
        }


        public List<Plato> BuscarPlatos(string consulta, List<SqlParameter> parametros)
        {
            try
            {
                //obtener registros en datatable
                DataTable resultado;

                if (parametros.Any())
                {
                    resultado = conexion.LeerPorComando(consulta,parametros.ToArray());
                }
                else { 
                    resultado = conexion.LeerPorComando(consulta);
                }


                // Si no hay resultados, retornar null
                if (resultado?.Rows.Count == 0)
                    return null;

                List<Plato> listaPlatos = new List<Plato>();

                foreach (DataRow row in resultado.Rows)
                {
                    Plato plato = new Plato();
                    plato.IdPlato = Convert.ToInt32(row["id_plato"]);
                    plato.Nombre = row["nombre"].ToString();
                    plato.TipoPlato = row["tipo_plato"].ToString();

                    //obtener ingredientes del plato
                    string consultaIngredientes = @"select id_plato_insumo,p_i.id_insumo, cantidad_necesaria,
                    i.nombre as nombre_insumo, unidad_medida,perecedero, i.fecha_baja as insumo_fecha_baja
                    from plato_insumo p_i
                    inner join insumo i on i.id_insumo = p_i.id_insumo
                    where p_i.id_plato = @IdPlato";

                    SqlParameter[] parametrosIngredientes = new SqlParameter[]
                    {
                        new SqlParameter("@IdPlato", SqlDbType.Int) { Value = plato.IdPlato }
                    };

                    DataTable resultadoIngredientes = conexion.LeerPorComando(consultaIngredientes, parametrosIngredientes);

                    List<PlatoInsumo> listaInsumos = new List<PlatoInsumo>();

                    foreach (DataRow rowInsumo in resultadoIngredientes.Rows)
                    {
                        PlatoInsumo platoInsumo = new PlatoInsumo();
                        platoInsumo.Insumo = new Insumo();
                        platoInsumo.IdPlatoInsumo = Convert.ToInt32(rowInsumo["id_plato_insumo"]);
                        platoInsumo.Insumo.IdInsumo = Convert.ToInt32(rowInsumo["id_insumo"]);
                        platoInsumo.CantidadNecesaria = Convert.ToDecimal(rowInsumo["cantidad_necesaria"]);
                        platoInsumo.Insumo.Nombre = rowInsumo["nombre_insumo"].ToString();
                        platoInsumo.Insumo.UnidadMedida = rowInsumo["unidad_medida"].ToString();
                        platoInsumo.Insumo.Perecedero = Convert.ToBoolean(rowInsumo["perecedero"]);
                        platoInsumo.Insumo.FechaBaja = rowInsumo["insumo_fecha_baja"] as DateTime?;
                        listaInsumos.Add(platoInsumo);
                    }
                    plato.ListaInsumos = listaInsumos;
                    listaPlatos.Add(plato);
                }

                return listaPlatos;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al buscar platos activos en DAL");
                throw ex;
            }


        }
    }
}
