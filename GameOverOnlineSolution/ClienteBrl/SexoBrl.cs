using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun;
using ClienteDal;

namespace ClienteBrl
{
    public class SexoBrl
    {
        public static Sexo Get(int i)
        {
            Sexo sexo = null;
            try
            {
                sexo = SexoDal.Get(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sexo;
        }
        public static List<Sexo> Get()
        {
            List<Sexo> sexoList = null;
            try
            {
                sexoList = SexoListDal.Get();
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("SexoBrl", "ListSexo",
                    string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(),
                    DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch
            {
                Methods.GenerateLogsRelease
            }
        }
        
    }
}
