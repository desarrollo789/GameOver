using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Comun;

namespace ClienteDal
{
    /// <summary>
    /// Clase que nos parmite interactuar con la base de datos de clite
    /// </summary>
    class UsuarioDal
    {
        /// <summary>
        /// Metodo que sirve para insertar a la base de datos
        /// </summary>
        /// <param name="usuario">Objeto paciente</param>
        public static void Insertar(Usuario usuario)
        {
            Methods.GenerateLogsDebug("UsuarioDal", "Insertar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un paciente"));
            SqlCommand command = null;

            // Proporcionar la cadena de consulta
            string queryString = @"INSERT INTO PACIENTES(PacienteId,Nombre,Apellido,SexoId,FechaNacimiento,Eliminado)
                                    VALUES
                                    (@pacienteId, @nombre, @apellido, @sexoId, @fechaNacimiento, @eliminado)";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                command.Parameters.AddWithValue("@usuarioId", usuario.UsuarioId);
                command.Parameters.AddWithValue("@sexoId", usuario.Sexo.SexoId);
                command.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
                command.Parameters.AddWithValue("@eliminado", 0);
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
            Methods.GenerateLogsDebug("UsuarioDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para insertar un paciente"));
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
        /// Actualiza los datos del paciente en la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        public static void Actulizar(Usuario usuario)
        {
            Methods.GenerateLogsDebug("UsuarioDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para Actualizar un usuario"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta
            string queryString = @"UPDATE USUARIO SET Nombre=@nombre, Apellido=@apellido, SexoId=@sexoId, fechaNacimiento=@fechaNacimiento, Eliminado= @eliminado Where UsuarioId=@usuarioId";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@pacienteId", usuario.UsuarioId);
                command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                command.Parameters.AddWithValue("@sexoId", usuario.Sexo.SexoId);
                command.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
                command.Parameters.AddWithValue("@eliminado", usuario.Eliminado);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("UsuarioDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("NombreDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            Methods.GenerateLogsDebug("NombreDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un paciente"));
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
            string query = "Select * From Pacientes where PacienteId = @id";
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
                        Sexo = SexoDal.Get(dr.GetByte(3)),
                        FechaNacimiento = dr.GetDateTime(4),
                        Eliminado = dr.GetBoolean(5)
                    };
                }
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("PacienteDal", "Obteber", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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








