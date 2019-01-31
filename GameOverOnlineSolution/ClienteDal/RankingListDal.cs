using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun;

namespace ClienteDal
{
    public class RankingListDal
    {
        public static RankingList Get()
        {
            RankingList res = new RankingList();

            SqlCommand cmd = null;
            SqlDataReader dr = null;

            string query = "SELECT * FROM Ranking";
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                dr = Methods.ExecuteDataReaderCommand(cmd);

                while (dr.Read())
                {
                    int idRanking = dr.GetInt32(0);
                    Ranking ranking = RankingDal.Get(idRanking);

                    res.Add(new Ranking()
                    {
                        RankingId = ranking.RankingId,
                        Puntuacion = ranking.Puntuacion,
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
