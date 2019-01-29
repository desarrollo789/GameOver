using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Comun;

namespace ClienteDal
{
    public class KeyValueUsuarioListDal
    {
        /// <summary>
        /// Obtener una lista de pacientes key values
        /// </summary>
        /// <returns></returns>
        public static KeyValueUsuarioList Get()
        {
            Methods.GenerateLogsDebug("KeyValuePacienteListDal", "Get", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo paraobtener una lista de pacientes"));

            KeyValueUsuarioList res = new KeyValueUsuarioList();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = "SELECT UsuarioId, Concat(Nombre, ' ', Apellido) as 'Nombre completo' FROM Usuario Where Eliminado=0";
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                dr = Methods.ExecuteDataReaderCommand(cmd);

                while (dr.Read())
                {
                    res.Add(new KeyValueUsuario()
                    {
                        UsuarioId = dr.GetInt32(0),
                        NombreCompleto = dr.GetString(1)
                    });
                }
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("KeyValueUsuarioListDal", "Obtener", ex.Message + " " + ex.StackTrace);
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("KeyValueUsuarioListDal", "Obtener", ex.Message + " " + ex.StackTrace);
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
