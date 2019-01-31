using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Comun;

namespace ClienteDal
{
    public class RankingDal
    {

        /// <summary>
        /// Metodo que sirve para insertar un ranking a la base de datos
        /// </summary>
        /// <param name="paciente">Objeto ranking</param>
        public static void Insertar(Ranking ranking)
        {
            Methods.GenerateLogsDebug("RankingDal", "Insertar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un ranking"));

            SqlCommand command = null;
            // Proporcionar la cadena de consulta 
            string queryString = @"INSERT INTO Ranking(RankingId, Puntuacion)
                                    VALUES
                                   (@rankingid, @puntuacion)";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@rankingid", ranking.RankingId);
                command.Parameters.AddWithValue("@puntuacion", ranking.Puntuacion);
                //command.Parameters.AddWithValue("@videojuegoId", videojuego.VideoJuegoId);
                command.Parameters.AddWithValue("@eliminado", ranking.Eliminado);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("RankingDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("RankingDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Methods.GenerateLogsDebug("RankingDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para insertar un ranking"));
        }
        /// <summary>
        /// Eliminar Ranking
        /// </summary>
        /// <param name="id">Identificador del ranking</param>
        public static void Eliminar(int id)
        {
            Methods.GenerateLogsDebug("RankingDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un ranking"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = "UPDATE Ranking SET Eliminado = 1 WHERE RankingId=@id";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@id", id);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("RankingDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("RankingDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Methods.GenerateLogsDebug("RankingDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para eliminar un ranking"));

        }
        /// <summary>
        /// Actualiza los datos del ranking en la base de datos
        /// </summary>
        /// <param name="ranking"></param>
        public static void Actualizar(Ranking ranking)
        {
            Methods.GenerateLogsDebug("RankingDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para Actualizar un ranking"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Ranking SET Puntuacion=@puntuacion, Eliminado=@eliminado Where RankingId=@rankingid";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@rankingid", ranking.RankingId);
                command.Parameters.AddWithValue("@puntuacion", ranking.Puntuacion);                
                command.Parameters.AddWithValue("@eliminado", ranking.Eliminado);
                
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("RankingDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("RankingDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Methods.GenerateLogsDebug("RankingDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un ranking"));

        }
        /// <summary>
        /// Obtiene  la informacion de un ranking
        /// </summary>
        /// <param name="id">identificador del ranking</param>
        /// <returns></returns>
        public static Ranking Get(int id)
        {
            Ranking res = new Ranking();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = "Select * From Ranking where RankingId = @id";
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = Methods.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Ranking()
                    {
                        RankingId = dr.GetInt32(0),
                        Puntuacion = dr.GetInt32(1),                        
                        Eliminado = dr.GetByte(2),                        
                        //ProveedorId = ProveedorDal.Get(dr.GetInt32(7)),                        
                    };
                }
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("RankingDal", "Obtener", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
