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
    public class UsuarioLisBrl
    {
         /// <summary>
         /// Obtiene la lista de videojuegos
         /// </summary>
         /// <returns>Categoria Lista</returns>
    public static UsuarioList Get()
    {
        UsuarioList lista = null;

        try
        {
            lista = UsuarioListDal.Get();

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
