using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Comun;

namespace ClienteDal
{
    public class ComentarioDal
    {
        /// <summary>
        /// Metodo que sirve para insertar una categoria a la base de datos
        /// </summary>
        /// <param name="paciente">Objeto categoria</param>
        public static void Insertar(Comentario comentario)
        {
            Methods.GenerateLogsDebug("ComentarioDal", "Insertar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un comentario"));

            SqlCommand command = null;
            // Proporcionar la cadena de consulta 
            string queryString = @"INSERT INTO Comentario(UsuarioId,Comentariotext,Eliminado)
                                    VALUES
                                   (@usuarioid, @comentariotext, @eliminado)";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@comentarioid", comentario.ComentarioId);
                command.Parameters.AddWithValue("@usuarioid", comentario.UsuarioId);
                //command.Parameters.AddWithValue("@videojuegoId", videojuego.VideoJuegoId);
                command.Parameters.AddWithValue("@comentariotext", comentario.Comentariotext);                

                command.Parameters.AddWithValue("@eliminado", comentario.Eliminado);
                Methods.ExecuteBasicCommand(command);
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

            Methods.GenerateLogsDebug("ComentarioDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para insertar un comentario"));
        }
        /// <summary>
        /// Eliminar Comentario
        /// </summary>
        /// <param name="id">Identificador del comentario</param>
        public static void Eliminar(int id)
        {
            Methods.GenerateLogsDebug("ComentarioDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un comentario"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = "UPDATE Comentario SET Eliminado = 1 WHERE ComentarioId=@id";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@id", id);
                Methods.ExecuteBasicCommand(command);
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

            Methods.GenerateLogsDebug("ComentarioDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para eliminar un comentario"));

        }
        /// <summary>
        /// Actualiza los datos del comentario en la base de datos
        /// </summary>
        /// <param name="comentario"></param>
        public static void Actualizar(Comentario comentario)
        {
            Methods.GenerateLogsDebug("ComentarioDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para Actualizar un comentario"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Comentario SET UsuariId=@usuarioid, Comentariotext=@comentariotext, Eliminado= @eliminado Where ComentarioId=@comentarioid";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@comentarioid", comentario.ComentarioId);
                command.Parameters.AddWithValue("@usuarioid", comentario.UsuarioId);
                command.Parameters.AddWithValue("@comentariotext", comentario.Comentariotext);                               
                command.Parameters.AddWithValue("@eliminado", comentario.Eliminado);

                Methods.ExecuteBasicCommand(command);
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

            Methods.GenerateLogsDebug("ComentarioDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un comentario"));

        }
        /// <summary>
        /// Obtiene  la informacion de un comentario
        /// </summary>
        /// <param name="id">identificador del comentario</param>
        /// <returns></returns>
        public static Comentario Get(int id)
        {
            Comentario res = new Comentario();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = "Select * From Comentario where ComentarioId = @id";
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = Methods.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Comentario()
                    {
                        ComentarioId = dr.GetInt32(0),
                        Comentariotext = dr.GetString(2),
                        UsuarioId = UsuarioDal.Get(dr.GetInt32(0)),
                        Eliminado = dr.GetByte(3),
                        //ProveedorId = ProveedorDal.Get(dr.GetInt32(7)),                        
                    };
                }
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("ComentarioDal", "Obtener", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return res;
        }
    }
}
