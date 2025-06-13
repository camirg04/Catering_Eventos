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

        public bool AgregarIngrediente(int idPlato, int idInsumo, Decimal cantidad)
        {
            string consulta = @"insert into plato_insumo (id_plato, id_insumo, cantidad_necesaria) values (@Id_plato,@IdInsumo,@Cantidad)";
            try
            {
                // Crear parámetros
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@Id_plato", SqlDbType.BigInt, 100) { Value = idPlato },
                new SqlParameter("@IdInsumo", SqlDbType.BigInt, 100) { Value = idInsumo },
                new SqlParameter("@Cantidad", SqlDbType.Decimal, 100) { Value = cantidad }
                };
                int filasAfectadas = conexion.EscribirPorComando(consulta, parametros);

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al agregar ingrediente a plato en DAL " + consulta);
                throw;
            }
      

        }

        public bool EditarIngrediente(int idPlato, int idInsumo, Decimal cantidad, int idPlatoInsumo)
        {
            string consulta = @"update plato_insumo set id_plato = @Id_plato, id_insumo = @IdInsumo, cantidad_necesaria = @Cantidad where id_plato_insumo = @Id_plato_insumo";
            try
            {
                // Crear parámetros
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@Id_plato", SqlDbType.BigInt, 100) { Value = idPlato },
                new SqlParameter("@IdInsumo", SqlDbType.BigInt, 100) { Value = idInsumo },
                new SqlParameter("@Id_plato_insumo", SqlDbType.BigInt, 100) { Value = idPlatoInsumo },
                new SqlParameter("@Cantidad", SqlDbType.Decimal, 100) { Value = cantidad }
                };
                int filasAfectadas = conexion.EscribirPorComando(consulta, parametros);

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al editar ingrediente a plato en DAL " + consulta);
                throw;
            }


        }

        public bool EliminarIngrediente(int idPlatoInsumo)
        {
            string consulta = @"delete from plato_insumo where id_plato_insumo = @Id_plato_insumo";
            try
            {           
                // Crear parámetros
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@Id_plato_insumo", SqlDbType.BigInt, 100) { Value = idPlatoInsumo }
                };
                int filasAfectadas = conexion.EscribirPorComando(consulta, parametros);

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al eliminar ingrediente a plato en DAL: " + consulta);
                throw;
            }


        }

        public int EditarPlato(string nombrePlato, string tipo, DateTime? fechaBaja, int id_plato)
        {
            string consulta = @"update plato set nombre = @Nombre, tipo_plato = @Tipo, fecha_baja = @FechaBaja where id_plato = @Idplato";
            try
            {
                // Crear parámetros
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", SqlDbType.VarChar, 100) { Value = nombrePlato },
                    new SqlParameter("@Tipo", SqlDbType.VarChar, 100) { Value = tipo },
                    new SqlParameter("@FechaBaja", SqlDbType.Date, 100) { Value = fechaBaja ?? (object)DBNull.Value },
                    new SqlParameter("@Idplato", SqlDbType.BigInt, 100) { Value = id_plato }
                };
                int afectados = conexion.EscribirPorComando(consulta, parametros);

                if (afectados > 0)
                {
                    return afectados;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al agregar plato a plato en DAL " + consulta);
                throw;
            }


        }



        public int AgregarPlato(string nombrePlato, string tipo, DateTime? fechaBaja)
        {
            string consulta = @"insert into plato (nombre, tipo_plato, fecha_baja) OUTPUT INSERTED.id_plato values  (@Nombre,@Tipo,@FechaBaja)";
            try
            {
                // Crear parámetros
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@Nombre", SqlDbType.VarChar, 100) { Value = nombrePlato },
                new SqlParameter("@Tipo", SqlDbType.VarChar, 100) { Value = tipo },
                new SqlParameter("@FechaBaja", SqlDbType.Date, 100) { Value = fechaBaja ?? (object)DBNull.Value }
                };
                int idCreado = conexion.EscribirPorComandoExecuteScalar(consulta, parametros);

                if (idCreado > 0)
                {
                    return idCreado;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al agregar plato a plato en DAL " + consulta);
                throw;
            }


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
                    plato.FechaBaja = row["fecha_baja"] as DateTime?;

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
                throw;
            }


        }


        public List<Plato> BuscarPlatosPorMenu(int idMenu)
        {
            try
            {
                var idPlatos = new List<int>();
                SqlParameter[] parametros = new SqlParameter[]
                    {
                new SqlParameter("@id_menu", SqlDbType.BigInt, 50) { Value = idMenu }
                    };
                var dt = conexion.LeerPorStoreProcedure("sp_ObtenerPlatosPorMenu", parametros);


                // Si no hay resultados, retornar null
                if (dt?.Rows.Count == 0)
                    return null;

                foreach (DataRow row in dt.Rows)
                {
                   idPlatos.Add(Convert.ToInt32(row["id_plato"]));
                }

                var platos = new List<Plato>();

                foreach(var id in idPlatos)
                {
                    var plato = new Plato();
                    var ingredientes = new List<PlatoInsumo>();
                    plato.IdPlato = id;
                    parametros = new SqlParameter[]
                    {
                        new SqlParameter("@id_plato", SqlDbType.BigInt, 50) { Value = idMenu }
                    };
                    dt = conexion.LeerPorStoreProcedure("sp_ObtenerIngredientesPlatoPorPlato", parametros);

                    foreach (DataRow row in dt.Rows)
                    {
                        PlatoInsumo platoInsumo = new PlatoInsumo();
                        platoInsumo.Insumo = new Insumo();
                        platoInsumo.IdPlatoInsumo = Convert.ToInt32(row["id_plato_insumo"]);
                        platoInsumo.Insumo.IdInsumo = Convert.ToInt32(row["id_insumo"]);
                        platoInsumo.CantidadNecesaria = Convert.ToDecimal(row["cantidad_necesaria"]);
                        platoInsumo.Insumo.Nombre = row["nombre_insumo"].ToString();
                        platoInsumo.Insumo.UnidadMedida = row["unidad_medida"].ToString();
                        platoInsumo.Insumo.Perecedero = Convert.ToBoolean(Convert.ToInt32(row["perecedero"]));
                        platoInsumo.Insumo.FechaBaja = row["insumo_fecha_baja"] as DateTime?;
                        platoInsumo.Insumo.StockMinimo = Convert.ToDecimal(row["stock_minimo"]);
                        ingredientes.Add(platoInsumo);
                    }
                    plato.ListaInsumos = ingredientes;
                    platos.Add(plato);
                }
                return platos;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al buscar platos por menú en DAL");
                throw;
            }


        }




    }
}
