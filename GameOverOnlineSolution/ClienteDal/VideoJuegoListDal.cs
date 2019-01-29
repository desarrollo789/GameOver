using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun;

namespace ClienteDal
{
    public class VideoJuegoListDal
    {
        public static VideoJuegoList Get()
        {
            VideoJuegoList res = new VideoJuegoList();

            SqlCommand cmd = null;
            SqlDataReader dr = null;

            string query = "SELECT * FROM Personal";
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                dr = Methods.ExecuteDataReaderCommand(cmd);

                while (dr.Read())
                {
                    int idVideoJuego = dr.GetInt32(0);
                    VideoJuego videojuego = VideoJuegoDal.Get(idVideoJuego);

                    res.Add(new VideoJuego()
                    {
                        VideoJuegoId = idVideoJuego,
                        Nombre = videojuego.Nombre,
                        Categoria = videojuego.Categoria,
                        Fecha = videojuego.Fecha,
                        Precio = videojuego.Precio,
                        Trailer = videojuego.Trailer,
                        Eliminado = videojuego.Eliminado,
                        Comentario = videojuego.Comentario,
                        Portada = videojuego.Portada,
                        Rankin = videojuego.Rankin,
                    });
                }
            }
            catch (SqlException ex)
            {
                //Methods.GenerateLogsRelease("KeyValuePacienteListDal", "Obtener", ex.Message + " " + ex.StackTrace);
                throw ex;
            }
            catch (Exception ex)
            {
                //Methods.GenerateLogsRelease("KeyValuePacienteListDal", "Obtener", ex.Message + " " + ex.StackTrace);
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
