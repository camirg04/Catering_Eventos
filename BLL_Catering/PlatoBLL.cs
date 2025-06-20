﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Catering;
using DAL_Catering;
using NLog;
using System.Data.SqlClient;
using System.Data;
using DTO_Catering;
using System.Globalization;
using System.ComponentModel;

namespace BLL_Catering
{
    public class PlatoBLL
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly PlatoDAL _platoDAL;
        private readonly ValidacionesBLL _validaciones;
        public PlatoBLL() {
            _platoDAL = new PlatoDAL();
            _validaciones = new ValidacionesBLL();
        }


        public List<Plato> BuscarPlatos(string nombre, string tipo, string activo)
        {
            try
            {
                StringBuilder consulta = new StringBuilder(@"SELECT id_plato, nombre, tipo_plato, fecha_baja FROM plato");
                List<SqlParameter> parametros = new List<SqlParameter>();
                List<string> condiciones = new List<string>();

                if (!(nombre == null || nombre.Trim() == ""))
                {
                    condiciones.Add("nombre LIKE @Nombre");
                    parametros.Add(new SqlParameter("@Nombre", "%" + nombre + "%"));
                }

                if (!(tipo == null || tipo.Trim() == ""))
                {
                    condiciones.Add("tipo_plato LIKE @Tipo");
                    parametros.Add(new SqlParameter("@Tipo", "%" + tipo + "%"));
                }

                if (!(activo == null || activo.Trim() == ""))
                {
                    if (activo == "Si")
                        condiciones.Add("fecha_baja IS NULL");
                    else if (activo == "No")
                        condiciones.Add("fecha_baja IS NOT NULL");
                }

                if (condiciones.Any())
                {
                    consulta.Append(" WHERE " + string.Join(" AND ", condiciones));
                }

                return _platoDAL.BuscarPlatos(consulta.ToString(), parametros);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al filtrar platos en BLL");
                throw ex;
            }
           

        }


        public List<Plato> BuscarPlatosPorMenu(int idMenu)
        {
            try
            {
                return _platoDAL.BuscarPlatosPorMenu(idMenu);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al filtrar platos en BLL");
                throw ex;
            }

        }





        public bool guardarCambiosPlato(string accion, Plato plato, List<InsumoPlatoDTO> platosAgregar, List<InsumoPlatoDTO> platosEditar, List<InsumoPlatoDTO> platosEliminar)
        {
            try
            {
                int ok = 0;
                if (accion == "editar")
                {
                    ok = _platoDAL.EditarPlato(plato.Nombre, plato.TipoPlato, plato.FechaBaja, plato.IdPlato);
                }
                else
                {
                    plato.IdPlato = _platoDAL.AgregarPlato(plato.Nombre, plato.TipoPlato, plato.FechaBaja);
                    ok = plato.IdPlato;
                }
                if(ok <= 0)
                {
                    return false;
                }

                modificarIngredientes(plato.IdPlato, platosAgregar, platosEditar, platosEliminar);

                return true;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al guardar cambios en BLL");
                throw;
            }
            
        }

        private bool modificarIngredientes(int id_plato,List<InsumoPlatoDTO> platosAgregar, List<InsumoPlatoDTO> platosEditar, List<InsumoPlatoDTO> platosEliminar) {

            try
            {
                bool exito = true;
                foreach (InsumoPlatoDTO insumo in platosAgregar)
                {
                    if (!_platoDAL.AgregarIngrediente(id_plato,insumo.IdInsumo,insumo.CantidadNecesaria))
                    {
                        exito =  false;
                    }
                }
                foreach (InsumoPlatoDTO insumo in platosEditar)
                {
                    if (!_platoDAL.EditarIngrediente(id_plato, insumo.IdInsumo, insumo.CantidadNecesaria,insumo.IdInsumoPlato))
                    {
                        exito = false;
                    }
                }
                foreach (InsumoPlatoDTO insumo in platosEliminar)
                {
                    if (!_platoDAL.EliminarIngrediente(insumo.IdInsumoPlato))
                    {
                        exito = false;
                    }
                }
                return exito;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error al modificar ingredientes en BLL");
                throw ex;
            }
        }
        

        
    }
}
