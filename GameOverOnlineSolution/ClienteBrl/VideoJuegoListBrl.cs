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
    public class VideoJuegoListBrl
    {
        /// <summary>
        /// Obtiene la lista de videojuegos
        /// </summary>
        /// <returns>Categoria Lista</returns>
        public static VideoJuegoList Get()
        {
            VideoJuegoList lista = null;

            try
            {
                lista = VideoJuegoListDal.Get();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;
        }
    }
}
