﻿using System;
using System.Data.SqlClient;
using Comun;
using VentaDal;

namespace ClienteBrl
{
    public class VentaBrl
    {
        #region Propiedades
        ///<summary>
        /// Metodo que sirve para insertar a la base de datos
        ///</summary>
        ///<param name="Venta">Objeto Usuario</param>
        public static void Insertar(Venta venta)
        {
            try
            {
                VentaDal.Insertar(venta);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("VentaBrl", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("VentaBrl", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }
        /// <summary>
        /// Eliminar Usuario
        /// </summary>
        /// <param name="id">Identificador del usuario</param>
        public static void Eliminar(int id)
        {
            try
            {
                VentaDal.Eliminar(id);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("VentaBrl", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("VentaBrl", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        /// <summary>
        /// Actualiza los datos del paciente en la base de datos
        /// </summary>
        /// <param name="venta"></param>
        public static void Actualizar(Venta venta)
        {
            try
            {
                VentaDal.Actualizar(venta);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("VentaBrl", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("VentaBrl", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            Methods.GenerateLogsDebug("VentaDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un usuario"));
        }

        /// <summary>
        /// Obtine  la informacion de un usuario
        /// </summary>
        /// <param name="id">identificador del usuario</param>
        /// <returns></returns>

        public static Venta Get(int id)
        {
            Venta res = new Venta();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = "Select * From Usuario where VentaId = @id";
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = Methods.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Venta()
                    {
                        VentaId = dr.GetInt32(0),
                        VideoJuegoId = dr.GetInt32(1),
                        ClienteId = dr.GetInt32(2),
                        Fecha = dr.GetDateTime(4),
                    };
                }

            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("VentaDal", "Obtener", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return res;
        }
        #endregion
    }
}
