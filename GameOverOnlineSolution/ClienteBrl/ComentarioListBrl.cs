using System;
using System.Data.SqlClient;
using Comun;
using ClienteDal;

namespace ClienteBrl
{
    class ComentarioListBrl
    {
        /// <summary>
        /// Obtiene una lista de comentarios
        /// </summary>
        /// <returns>Comentario Lista</returns>
        public static ComentarioList Get()
        {
            ComentarioList lista = null;

            try
            {
                lista = ComentarioListDal.Get();

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
