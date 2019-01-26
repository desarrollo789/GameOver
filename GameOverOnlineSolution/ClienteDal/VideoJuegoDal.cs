using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Comun;

namespace ClienteDal
{
    public class VideoJuegoDal
    {
        /// <summary>
        /// Metodo que sirve para insertar a la base de datos
        /// </summary>
        /// <param name="paciente">Objeto video juego</param>
        public static void Insertar(VideoJuego videojuego)
        {
            Methods.GenerateLogsDebug("VideoJuegoDal", "Insertar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un paciente"));

            SqlCommand command = null;
            // Proporcionar la cadena de consulta 
            string queryString = @"INSERT INTO PACIENTES(PacienteId,Nombre,Apellido,SexoId,FechaNacimiento,Eliminado)
                                    VALUES
                                   (@pacienteId, @nombre, @apellido, @sexoId, @fechaNacimiento, @eliminado)";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@nombre", paciente.Nombre);
                command.Parameters.AddWithValue("@apellido", paciente.Apellido);
                command.Parameters.AddWithValue("@pacienteId", paciente.PacienteId);
                command.Parameters.AddWithValue("@sexoId", paciente.Sexo.SexoId);
                command.Parameters.AddWithValue("@fechaNacimiento", paciente.FechaNacimiento);
                command.Parameters.AddWithValue("@eliminado", 0);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("PacienteDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("PacienteDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Methods.GenerateLogsDebug("PacienteDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para insertar un paciente"));
        }
        /// <summary>
        /// Eliminar VideoJuego
        /// </summary>
        /// <param name="id">Identificador del videojuego</param>
        public static void Eliminar(int id)
        {
            Methods.GenerateLogsDebug("PacienteDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un paciente"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = "UPDATE Pacientes SET Eliminado = 1 WHERE PacienteId=@id";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@id", id);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Methods.GenerateLogsDebug("VideoJuegoDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para insertar un paciente"));

        }
        /// <summary>
        /// Actualiza los datos del videojuego en la base de datos
        /// </summary>
        /// <param name="video juego"></param>
        public static void Actualizar(VideoJuego videojuego)
        {
            Methods.GenerateLogsDebug("VideoJuegoDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para Actualizar un paciente"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE PACIENTES SET Nombre=@nombre, Apellido=@apellido, SexoId=@sexoId, fechaNacimiento=@fechaNacimiento, Eliminado= @eliminado Where PacienteId=@pacienteId";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@pacienteId", paciente.PacienteId);
                command.Parameters.AddWithValue("@nombre", paciente.Nombre);
                command.Parameters.AddWithValue("@apellido", paciente.Apellido);
                command.Parameters.AddWithValue("@sexoId", paciente.Sexo.SexoId);
                command.Parameters.AddWithValue("@fechaNacimiento", paciente.FechaNacimiento);
                command.Parameters.AddWithValue("@eliminado", paciente.Eliminado);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Methods.GenerateLogsDebug("VideoJuegoDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un paciente"));

        }
        /// <summary>
        /// Obtine  la informacion de un video juego
        /// </summary>
        /// <param name="id">identificador del videojuego</param>
        /// <returns></returns>
        public static VideoJuego Get(int id)
        {
            VideoJuego res = new VideoJuego();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = "Select * From Pacientes where PacienteId = @id"
                try
            {
                cmd = Methods.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = Methods.ExecuteDataReaderCommand(cmd);
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("VideoJuegoDal", "Obteber", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
