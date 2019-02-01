using System;
using System.Data.SqlClient;
using Comun;
using ClienteDal;

namespace ClienteBrl
{
    public class CategoriaListBrl
    {
        /// <summary>
        /// Obtiene una lista de categorias
        /// </summary>
        /// <returns>Categoria Lista</returns>
        public static CategoriaList Get()
        {
            CategoriaList lista = null;

            try
            {
                lista = CategoriaListDal.Get();

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
