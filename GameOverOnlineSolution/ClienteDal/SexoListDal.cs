using System;
using System.Data.SqlClient;
using Comun;
namespace ClienteDal
{
    public class SexoListDal
    {
        /// <summary>
        /// Obtener un listan de sexos
        /// </summary>
        /// <returns></returns>
        public static SexoList Get()
        {
            SexoList res = new SexoList();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = "SELECT SexoId, Nombre FROM Sexos";
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                dr = Methods.ExecuteDataReaderCommand(cmd);

                while (dr.Read())
                {
                    res.Add(new Sexo()
                    {
                        SexoId = dr.GetByte(0),
                        Nombre = dr.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("SexoListDal", "Obteber", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
