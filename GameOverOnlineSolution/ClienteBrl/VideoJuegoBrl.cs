using System;
using System.Data.SqlClient;
using Comun;
using ClienteDal;

namespace ClienteBrl
{
    class VideoJuegoBrl
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
    }
}
