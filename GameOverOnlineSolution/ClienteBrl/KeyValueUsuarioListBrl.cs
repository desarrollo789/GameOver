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
    class KeyValueUsuarioListBrl
    {
        /// <summary>
        /// Obtener una lista de pacientes key values
        /// </summary>
        /// <returns></returns>
        public static KeyValueUsuarioList Get()
        {
            KeyValueUsuarioList list = null;
            try
            {
                list = KeyValueUsuarioListDal.Get();
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("KeyValueUsuarioListBrl", "Get", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("KeyValueUsuarioListBrl", "Get", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            return list;
        }
    }
}
