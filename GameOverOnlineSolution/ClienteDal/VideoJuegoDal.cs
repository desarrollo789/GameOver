using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Comun;

namespace ClienteDal
{
    public class VideoJuegoDal
    {
        /// <summary>
        /// Metodo que sirve para insertar un videojuego a la base de datos
        /// </summary>
        /// <param name="paciente">Objeto videojuego</param>
        public static void Insertar(VideoJuego videojuego)
        {
            Methods.GenerateLogsDebug("VideoJuegoDal", "Insertar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un videojuego"));

            SqlCommand command = null;
            // Proporcionar la cadena de consulta 
            string queryString = @"INSERT INTO VideoJuego(Nombre,Precio,Portada,Trailer,Fecha,RankingId,CategoriaId,ComentarioId,ProveedorId,Eliminado)
                                    VALUES
                                   (@nombre, @precio, @portada, @trailer, @fecha, @rankingid, @categoriaid, @comentarioid, @proveedorid, @eliminado)";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@nombre", videojuego.Nombre);
                command.Parameters.AddWithValue("@precio", videojuego.Precio);
                //command.Parameters.AddWithValue("@videojuegoId", videojuego.VideoJuegoId);
                command.Parameters.AddWithValue("@portada",videojuego.Portada);
                command.Parameters.AddWithValue("@trailer", videojuego.Trailer);
                command.Parameters.AddWithValue("@fecha", videojuego.Fecha);
                command.Parameters.AddWithValue("@rankingid",videojuego.RankingId.RankingId);
                command.Parameters.AddWithValue("@categoriaid", videojuego.CategoriaId.CategoriaId);
                command.Parameters.AddWithValue("@comentarioid",videojuego.ComentarioId.ComentarioId);
                command.Parameters.AddWithValue("@proveedorid", videojuego.ProveedorId.ProveedorId);

                command.Parameters.AddWithValue("@eliminado", videojuego.Eliminado);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Methods.GenerateLogsDebug("VideoJuegoDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para insertar un videojuego"));
        }
        /// <summary>
        /// Eliminar VideoJuego
        /// </summary>
        /// <param name="id">Identificador del videojuego</param>
        public static void Eliminar(int id)
        {
            Methods.GenerateLogsDebug("VideoJuegoDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un videojuego"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = "UPDATE VideoJuego SET Eliminado = 1 WHERE VideoJuegoId=@id";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@id", id);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Methods.GenerateLogsDebug("VideoJuegoDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para eliminar un videojuego"));

        }
        /// <summary>
        /// Actualiza los datos del videojuego en la base de datos
        /// </summary>
        /// <param name="videojuego"></param>
        public static void Actualizar(VideoJuego videojuego)
        {
            Methods.GenerateLogsDebug("VideoJuegoDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para Actualizar un videojuego"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE VideoJuego SET Nombre=@nombre, Precio=@precio, Portada=@portada, Trailer=@trailer, Fecha=@fecha, RankingId=@rankingid, CategoriaId=@categoriaid, CometarioId=@comentarioid, ProveedorId=@proveedorid, Eliminado= @eliminado Where VideoJuegoId=@videojuegoid";
            try
            {
                command = Methods.CreateBasicCommand(queryString);             
                command.Parameters.AddWithValue("@nombre", videojuego.Nombre);
                command.Parameters.AddWithValue("@precio", videojuego.Precio);        
                command.Parameters.AddWithValue("@portada", videojuego.Portada);
                command.Parameters.AddWithValue("@trailer", videojuego.Trailer);
                command.Parameters.AddWithValue("@fecha", videojuego.Fecha);
                command.Parameters.AddWithValue("@rankingid", videojuego.RankingId);
                command.Parameters.AddWithValue("@categoriaid", videojuego.CategoriaId);
                command.Parameters.AddWithValue("@comentarioid", videojuego.ComentarioId);
                command.Parameters.AddWithValue("@proveedorid", videojuego.ProveedorId);
                command.Parameters.AddWithValue("@eliminado", videojuego.Eliminado);

                command.Parameters.AddWithValue("@videojuegoId", videojuego.VideoJuegoId);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Methods.GenerateLogsDebug("VideoJuegoDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un videojuego"));

        }
        /// <summary>
        /// Obtiene  la informacion de un videojuego
        /// </summary>
        /// <param name="id">identificador del videojuego</param>
        /// <returns></returns>
        public static VideoJuego Get(int id)
        {
            VideoJuego res = new VideoJuego();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = "Select * From VideoJuego where VideoJuegoId = @id";
                try
            {
                cmd = Methods.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = Methods.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new VideoJuego()
                    {                        
                        VideoJuegoId = dr.GetInt32(0),
                        Nombre = dr.GetString(1),
                        Precio = dr.GetInt32(2),
                        Portada = dr.GetString(3),
                        Trailer = dr.GetString(4),
                        Eliminado = dr.GetByte(5),
                        Fecha = dr.GetDateTime(6),
                        ProveedorId = ProveedorDal.Get(dr.GetInt32(0)),
                        RankingId = RankingDal.Get(dr.GetInt32(0)),
                        CategoriaId = CategoriaDal.Get(dr.GetInt32(0)),
                        ComentarioId = ComentarioDal.Get(dr.GetInt32(0)),

                        //ProveedorId = ProveedorDal.Get(dr.GetInt32(0)),
                    };
                }
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoDal", "Obtener", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
