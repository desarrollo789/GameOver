using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun;

namespace ClienteDal
{
    public class ComentarioListDal
    {
        public static ComentarioList Get()
        {
            ComentarioList res = new ComentarioList();

            SqlCommand cmd = null;
            SqlDataReader dr = null;

            string query = "SELECT * FROM Comentario";
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                dr = Methods.ExecuteDataReaderCommand(cmd);

                while (dr.Read())
                {
                    int idComentario = dr.GetInt32(0);
                    Comentario comentario = ComentarioDal.Get(idComentario);

                    res.Add(new Comentario()
                    {
                        ComentarioId = idComentario,
                        UsuarioId = comentario.UsuarioId,
                        Comentariotext = comentario.Comentariotext,                        
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
