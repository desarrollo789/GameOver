using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun;

namespace ClienteDal
{
    class CategoriaListDal
    {
        public static CategoriaList Get()
        {
            CategoriaList res = new CategoriaList();

            SqlCommand cmd = null;
            SqlDataReader dr = null;

            string query = "SELECT * FROM Categoria";
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                dr = Methods.ExecuteDataReaderCommand(cmd);

                while (dr.Read())
                {
                    int idcategoria = dr.GetInt32(0);
                    Categoria categoria = CategoriaDal.Get(idcategoria);

                    res.Add(new Categoria()
                    {
                        CategoriaId = idcategoria,
                        Nombre = categoria.Nombre,                                              
                        Eliminado = categoria.Eliminado,                        
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
