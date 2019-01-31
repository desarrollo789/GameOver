using System;
using System.Data.SqlClient;
using Comun;
using ClienteDal;

namespace ClienteBrl
{
    public class UsuarioBrl
    {
        ///<summary>
        /// Metodo que sirve para insertar a la base de datos
        ///</summary>
        ///<param name="Usario">Objeto Usuario</param>
        public static void Insertar(Usuario usuario)
        {
            try
            {
                UsuarioDal.Insertar(usuario);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("UsuarioBrl", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("UsuarioBrl", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }
        /// <summary>
        /// Eliminar Usuario
        /// </summary>
        /// <param name="id">Identificador del usuario</param>
        public static void Eliminar(int id)
        {
            try
            {
                UsuarioDal.Eliminar(id);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("UsuarioBrl", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("UsuarioBrl", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        /// <summary>
        /// Actualiza los datos del paciente en la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        public static void Actualizar(Usuario usuario)
        {
            try
            {
                UsuarioDal.Actualizar(usuario);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("UsuarioBrl", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("UsuarioBrl", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            Methods.GenerateLogsDebug("UsuarioDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un usuario"));
        }

        /// <summary>
        /// Obtine  la informacion de un usuario
        /// </summary>
        /// <param name="id">identificador del usuario</param>
        /// <returns></returns>

        public static Usuario Get(int id)
        {
            Usuario res = new Usuario();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = "Select * From Usuario where PacienteId = @id";
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = Methods.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Usuario()
                    {
                        UsuarioId = dr.GetInt32(0),
                        Nombre = dr.GetString(1),
                        Apellido = dr.GetString(2),
                        SexoId = SexoDal.Get(dr.GetByte(3)),
                        FechaNacimiento = dr.GetDateTime(4),
                        Eliminado = dr.GetByte(5)
                    };
                }

            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("UsuarioDal", "Obteber", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
