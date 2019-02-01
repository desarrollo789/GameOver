using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Comun;
using ClienteDal;

namespace ClienteBrl
{
    public class ComentarioBrl
    {
        /// <summary>
        /// Metodo para Insertar un Comentario
        /// </summary>
        /// <param name="comentario"></param>
        public static void Insertar(Comentario comentario)
        {
            try
            {
                ComentarioDal.Insertar(comentario);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("ComentarioDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("ComentarioDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }
        /// <summary>
        /// Metodo para Obtener una Comentario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Comentario Get(int id)
        {
            Comentario comentario = null;
            try
            {
                comentario = ComentarioDal.Get(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return comentario;
        }
        /// <summary>
        /// actualiza un Comentario
        /// </summary>
        /// <param name="comentario"></param>

        public static void Actualizar(Comentario comentario)
        {
            try
            {
                ComentarioDal.Actualizar(comentario);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("ComentarioDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("ComentarioDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        /// <summary>
        /// Metodo para eliminar logicamente una Comentario
        /// </summary>
        /// <param name="id"></param>

        public static void Eliminar(int id)
        {
            try
            {
                ComentarioDal.Eliminar(id);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("ComentarioDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("ComentarioDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

        }
        /// <summary>
        /// Metodo para obtener una lista de comentarios de la base de datos
        /// </summary>
        /// <returns>List<Cliente></returns>

        public static List<Comentario> ListCategoria()
        {
            List<Comentario> comentarios = null;
            try
            {
                comentarios = ComentarioListDal.Get();
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("ComentarioBrl", "ListComentario",
                string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(),
                DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("ComentarioBrl", "ListComentario", string.Format("{0} {1} Error: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            return comentarios;

        }


    }
}
