﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Catering
{
    public class Conexion
    {
        private SqlConnection objConexion;
        private string strCadenaDeConexion = "";


        /* -------------------- private void Conectar() ------------ 
         * Este metodo como indica su nombre... me permite conectarme con la 
         * base de datos (en este caso, SqlServer)
         * 
         */
        private void Conectar()
        {   // HACK: Cadena de conexión hardcodeada. Luego ponerla como parametro de configuración del proyecto u otra alternativa.
            strCadenaDeConexion = @"Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = CATERINGDB; Data Source = .\SQLEXPRESS";
            //Instanció un objeto del tipo SqlConnection
            objConexion = new SqlConnection();
            objConexion.ConnectionString = strCadenaDeConexion;
            objConexion.Open();
        }

        /* -------------------- private void Desconectar() ------------ 
         * Este metodo como indica su nombre... me permite desconectarme de la
         * base de datos (en este caso, SqlServer)
         * 
         */
        private void Desconectar()
        {
            objConexion.Close();
            objConexion.Dispose();
        }

        public DataTable LeerPorStoreProcedure(string pNombreStoreProcedure, SqlParameter[] pParametrosSql = null)
        {
            //Instancio un objeto del tipo DataTable
            var unaTabla = new DataTable();

            //Instancio un objeto del tipo SqlCommand
            var objComando = new SqlCommand();

            //Me conecto...
            this.Conectar();


            try
            {
                objComando.CommandText = pNombreStoreProcedure;
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Connection = this.objConexion;

                if (pParametrosSql != null)
                {
                    //Lleno los SqlParameters a la lista de parametros
                    objComando.Parameters.AddRange(pParametrosSql);
                }

                //Instancio un adaptador con el parametro SqlCommand
                var objAdaptador = new SqlDataAdapter(objComando);

                //Lleno la tabla, el objeto unaTabla con el adaptador
                objAdaptador.Fill(unaTabla);
            }
            catch (Exception)
            {
                //Como hay error... por el motivo que sea asigno el resultado a null
                unaTabla = null;

                throw;
            }
            finally
            {

                //Pase lo que pase me desconecto
                this.Desconectar();
            }


            return unaTabla;
        }

        public DataTable LeerPorComando(string pComando)
        {
            //Instancio un objeto del tipo DataTable
            var unaTabla = new DataTable();

            //Instancio un objeto del tipo SqlCommand
            var objComando = new SqlCommand();

            //Me conecto...
            this.Conectar();

            try
            {


                //Parametrizo el objeto SqlCommand con sus valores respectivos
                objComando.CommandType = CommandType.Text;
                objComando.Connection = this.objConexion;
                objComando.CommandText = pComando;

                //Instancio un adaptador con el parametro SqlCommand
                var objAdaptador = new SqlDataAdapter(objComando);

                //Lleno la tabla, el objeto unaTabla con el adaptador
                objAdaptador.Fill(unaTabla);

            }
            catch
            {
                //Como hay error... por el motivo que sea asigno el resultado a null
                unaTabla = null;

                throw;
            }
            finally
            {
                //Siempre, por más que salga bien o mal el llenado, me desconecto
                this.Desconectar();
            }

            return unaTabla;
        }

        public int EscribirPorComandoExecuteScalar(string pTexto, SqlParameter[] pParametrosSql = null)
        {
            int idCreado = -1;
            var objComando = new SqlCommand();
            this.Conectar();

            try
            {
                // Configuración básica del comando
                objComando.CommandType = CommandType.Text;
                objComando.Connection = this.objConexion;
                objComando.CommandText = pTexto;
                objComando.CommandTimeout = 30; // Tiempo de espera en segundos

                // Agregar parámetros si existen
                if (pParametrosSql != null && pParametrosSql.Length > 0)
                {
                    objComando.Parameters.AddRange(pParametrosSql);
                }

                // Ejecuta y obtiene el ID generado
                object resultado = objComando.ExecuteScalar();

                if (resultado != null && int.TryParse(resultado.ToString(), out int id))
                {
                    idCreado = id;
                }
            }
            catch (Exception)
            {
                idCreado = -1;
                throw;
            }
            finally
            {
                this.Desconectar();
            }

            return idCreado;
        }

        public int EscribirPorComando(string pTexto)
        {
            //Instanció una variable filasAfectadas que va a terminar devolviendo la cantidad de filas afectadas.
            int filasAfectadas = 0;

            //Instancio un objeto del tipo SqlCommand
            var objComando = new SqlCommand();

            //Me conecto...
            this.Conectar();

            try
            {
                objComando.CommandText = pTexto;
                objComando.CommandType = CommandType.Text;
                objComando.Connection = this.objConexion;

                //El método ExecuteNonQuery() me devuelve la cantidad de filas afectadas.
                filasAfectadas = objComando.ExecuteNonQuery();


            }
            catch (Exception)
            {
                filasAfectadas = -1;
                throw;
            }
            finally
            {
                //Me desconecto
                this.Desconectar();
            }


            return filasAfectadas;
        }

        public int EscribirPorComando(string pTexto, SqlParameter[] pParametrosSql)
        {
            //Instanció una variable filasAfectadas que va a terminar devolviendo la cantidad de filas afectadas.
            int filasAfectadas = 0;

            //Instancio un objeto del tipo SqlCommand
            var objComando = new SqlCommand();

            //Me conecto...
            this.Conectar();

            try
            {
                // Configuración básica del comando
                objComando.CommandType = CommandType.Text;
                objComando.Connection = this.objConexion;
                objComando.CommandText = pTexto;
                objComando.CommandTimeout = 30; // Tiempo de espera en segundos

                // Agregar parámetros si existen
                if (pParametrosSql != null && pParametrosSql.Length > 0)
                {
                    objComando.Parameters.AddRange(pParametrosSql);
                }

                //El método ExecuteNonQuery() me devuelve la cantidad de filas afectadas.
                filasAfectadas = objComando.ExecuteNonQuery();


            }
            catch (Exception)
            {
                filasAfectadas = -1;
                throw;
            }
            finally
            {
                //Me desconecto
                this.Desconectar();
            }


            return filasAfectadas;
        }

        public int EscribirPorStoreProcedure(string pTexto, SqlParameter[] pParametrosSql)
        {
            //Instanció una variable filasAfectadas que va a terminar devolviendo la cantidad de filas afectadas.
            int filasAfectadas = 0;

            //Instancio un objeto del tipo SqlCommand
            var objComando = new SqlCommand();

            //Me conecto...
            this.Conectar();

            try
            {
                objComando.CommandText = pTexto;
                objComando.CommandType = CommandType.StoredProcedure;
                objComando.Connection = this.objConexion;

                if (pParametrosSql.Length > 0)
                {
                    objComando.Parameters.AddRange(pParametrosSql);
                    //El método ExecuteNonQuery() me devuelve la cantidad de filas afectadas.
                    filasAfectadas = objComando.ExecuteNonQuery();
                }
                else
                {
                    //retorno -1 porque la lista de parametros Sql tiene 0 ítems...
                    filasAfectadas = -1;
                }



            }
            catch (Exception)
            {
                filasAfectadas = -1;
                throw;
            }
            finally
            {
                //Me desconecto
                this.Desconectar();
            }


            return filasAfectadas;
        }

        public DataTable LeerPorComando(string pComando, SqlParameter[] parametros = null)
        {
            DataTable unaTabla = new DataTable();
            SqlCommand objComando = new SqlCommand();

            this.Conectar();

            try
            {
                // Configuración básica del comando
                objComando.CommandType = CommandType.Text;
                objComando.Connection = this.objConexion;
                objComando.CommandText = pComando;
                objComando.CommandTimeout = 30; // Tiempo de espera en segundos

                // Agregar parámetros si existen
                if (parametros != null && parametros.Length > 0)
                {
                    objComando.Parameters.AddRange(parametros);
                }

                // Ejecutar y llenar DataTable
                using (SqlDataAdapter objAdaptador = new SqlDataAdapter(objComando))
                {
                    objAdaptador.Fill(unaTabla);
                }
            }
            catch (SqlException sqlEx)
            {
                // Manejo específico para errores SQL
                unaTabla = null;
                throw new ApplicationException($"Error de SQL: {sqlEx.Number} - {sqlEx.Message}", sqlEx);
            }
            catch (Exception ex)
            {
                unaTabla = null;
                throw new ApplicationException("Error al ejecutar consulta", ex);
            }
            finally
            {
                this.Desconectar();

                // Limpieza de recursos
                if (objComando != null)
                {
                    objComando.Dispose();
                }
            }

            return unaTabla;
        }

        #region Parametros
        public SqlParameter crearParametro(string pNombre, string pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.String;

            return objParametro;
        }



        public SqlParameter crearParametro(string pNombre, double pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.Double;

            return objParametro;
        }


        public SqlParameter crearParametro(string pNombre, DateTime pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.DateTime;

            return objParametro;
        }


        public SqlParameter crearParametro(string pNombre, int pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.Int32;

            return objParametro;
        }


        public SqlParameter crearParametro(string pNombre, Boolean pValor)
        {

            SqlParameter objParametro = new SqlParameter();

            objParametro.ParameterName = pNombre;
            objParametro.Value = pValor;
            objParametro.DbType = DbType.Boolean;

            return objParametro;
        }
        #endregion
    }
}
