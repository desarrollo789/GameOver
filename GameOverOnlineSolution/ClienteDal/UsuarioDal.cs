using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Comun;

namespace ClienteDal
{
    /// <summary>
    /// Clase que nos permite interactuar con la base de datos de usuario
    /// </summary>
    public class UsuarioDal
    {
        /// <summary>
        /// Metodo que sirve para insertar a la base de datos
        /// </summary>
        /// <param name="usuario">Objeto usuario</param>
        public static void Insertar(Usuario usuario)
        {
            Methods.GenerateLogsDebug("UsuarioDal", "Insertar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para insertar un usuario"));
            SqlCommand command = null;

            // Proporcionar la cadena de consulta
            string queryString = @"INSERT INTO Usuario(Nombre, Apellido, CorreoElectronico , FechaNacimiento, Username, Administrador, Eliminado, SexoId, Fechaderegistro)
                                    VALUES
                                    (@nombre, @apellido, @correoelectronico, @sexoid, @fechanacimiento, @username, @administrador, @eliminado, @sexoid, @fechaderegistro)";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                command.Parameters.AddWithValue("@correoelectronico", usuario.CorreoElectronico);
                command.Parameters.AddWithValue("@fechanacimiento", usuario.FechaNacimiento);
                command.Parameters.AddWithValue("@username", usuario.Username);
                command.Parameters.AddWithValue("@administrador",usuario.Administrador);
                command.Parameters.AddWithValue("@eliminado", usuario.Eliminado);
                command.Parameters.AddWithValue("@sexoid", usuario.SexoId);
                command.Parameters.AddWithValue("@fechaderegistro", usuario.Fechaderegistro);

                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("UsuarioDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("UsurioDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            Methods.GenerateLogsDebug("UsuarioDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para insertar un usuario"));
        }
        /// <summary>
        /// Eliminar usuario
        /// </summary>
        /// <param name="id">Identificador del usuario</param>
        public static void Eliminar(int id)
        {
            Methods.GenerateLogsDebug("UsuarioDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un usuario"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = "UPDATE Usuario SET Eliminado = 1 WHERE UsuarioId=@id";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@id", id);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("UsuarioDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("UsuarioDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Methods.GenerateLogsDebug("UsuarioDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para insertar un paciente"));

        }
        /// <summary>
        /// Actualiza los datos del usuario en la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        public static void Actualizar(Usuario usuario)
        {
            Methods.GenerateLogsDebug("UsuarioDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para Actualizar un usuario"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta
            string queryString = @"UPDATE Usuario SET Nombre=@nombre, Apellido=@apellido, CorreoElectronico=@correoelectronico, FechaNacimiento=@fechanacimiento, Userneme=@username, Administrador=@administrador, Eliminado=@eliminado, SexoId=@sexoid, Fechaderegistro=@fechaderegistro Where UsuarioId=@usuarioId";
            try
            {
                command = Methods.CreateBasicCommand(queryString);                
                command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                command.Parameters.AddWithValue("@correoelectronico", usuario.CorreoElectronico);
                command.Parameters.AddWithValue("@fechanacimiento", usuario.FechaNacimiento);
                command.Parameters.AddWithValue("@username", usuario.Username);
                command.Parameters.AddWithValue("@administrador", usuario.Administrador);
                command.Parameters.AddWithValue("@eliminado", usuario.Eliminado);
                command.Parameters.AddWithValue("@sexoId", usuario.SexoId);
                command.Parameters.AddWithValue("@fechaderegistro", usuario.Fechaderegistro);
                

                command.Parameters.AddWithValue("@usuarioid", usuario.UsuarioId);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("UsuarioDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("UsuarioDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            Methods.GenerateLogsDebug("UsuarioDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un usuario"));
        }
        /// <summary>
        /// Obtine  la informacion de un paciente
        /// </summary>
        /// <param name="id">identificador del paciente</param>
        /// <returns></returns>
        public static Usuario Get(int id)
        {
            Usuario res = new Usuario();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = "Select * From Usuario where UsuarioId = @id";
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = Methods.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Usuario()
                    {////
                        UsuarioId = dr.GetInt32(0),
                        Nombre = dr.GetString(1),
                        Apellido = dr.GetString(2),
                        CorreoElectronico = dr.GetString(3),
                        FechaNacimiento = dr.GetDateTime(4),
                        Username = dr.GetString(5),
                        Administrador = dr.GetByte(6),
                        Eliminado = dr.GetByte(7),
                        SexoId = SexoDal.Get(dr.GetByte(0)),
                        Fechaderegistro = dr.GetDateTime(9)
                        
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








