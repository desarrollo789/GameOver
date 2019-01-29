using System;
using System.Data.SqlClient;
using Comun;
using ClienteDal;

namespace ClienteBrl
{
    public class VideoJuegoBrl
    {
        /// <summary>
        /// Metodo que sirve para insertar a la base de datos
        /// </summary>
        /// <param name="videojuego">Objeto brl</param>
        public static void Insertar(VideoJuego videojuego)
        {
            try
            {
                VideoJuegoDal.Insertar(videojuego);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoBrl", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoBrl", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }
        /// <summary>
        /// Eliminar Paciente
        /// </summary>
        /// <param name="id">Identificador del videojuego</param>
        public static void Eliminar(int id)
        {
            try
            {
                VideoJuegoDal.Eliminar(id);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoBrl", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoBrl", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }
        /// <summary>
        /// Actualiza los datos del videojuego en la base de datos
        /// </summary>
        /// <param name="videojuego"></param>
        public static void Actualizar(VideoJuego videojuego)
        {
            try
            {
                VideoJuegoDal.Actualizar(videojuego);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoBrl", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoBrl", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }
        /// <summary>
        /// Obtine  la informacion de un videojuego
        /// </summary>
        /// <param name="id">identificador del videojuego</param>
        /// <returns></returns>

        public static VideoJuego Get(int id)
        {
            VideoJuego videojuego = null;
            try
            {
                videojuego = VideoJuegoDal.Get(id);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoBrl", "Obtener", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoBrl", "Obtener", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            return videojuego;
        }
    }
}
