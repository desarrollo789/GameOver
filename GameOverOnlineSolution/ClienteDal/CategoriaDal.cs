using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Comun;

namespace ClienteDal
{
    public class CategoriaDal
    {
        /// <summary>
        /// Metodo que sirve para insertar un categoria a la base de datos
        /// </summary>
        /// <param name="paciente">Objeto categoria</param>
        public static void Insertar(Categoria categoria)
        {
            Methods.GenerateLogsDebug("CategoriaDal", "Insertar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar una categoria"));

            SqlCommand command = null;
            // Proporcionar la cadena de consulta 
            string queryString = @"INSERT INTO Categoria(Nombre,Eliminado)
                                    VALUES
                                   (@nombre, @eliminado)";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@nombre", categoria.Nombre);                
                //command.Parameters.AddWithValue("@videojuegoId", videojuego.VideoJuegoId);                               
                command.Parameters.AddWithValue("@categoriaid", categoria.CategoriaId);                
                command.Parameters.AddWithValue("@eliminado", categoria.Eliminado);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("CategoriaDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("CategoriaDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Methods.GenerateLogsDebug("CategoriaDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para insertar un categoria"));
        }
        /// <summary>
        /// Eliminar categoria
        /// </summary>
        /// <param name="id">Identificador del categoria</param>
        public static void Eliminar(int id)
        {
            Methods.GenerateLogsDebug("CategoriaDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar una categoria"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = "UPDATE Categoria SET Eliminado = 1 WHERE CategoriaId=@id";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@id", id);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("CategoriaDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("CategoriaDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Methods.GenerateLogsDebug("CategoriaDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para eliminar un categoria"));

        }
        /// <summary>
        /// Actualiza los datos de la categoria en la base de datos
        /// </summary>
        /// <param name="categoria"></param>
        public static void Actualizar(Categoria categoria)
        {
            Methods.GenerateLogsDebug("CategoriaDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para Actualizar una categoria"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Categoria SET Nombre=@nombre, Eliminado= @eliminado Where CategoriaId=@categoriaid";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@nombre", categoria.Nombre);                
                command.Parameters.AddWithValue("@categoriaid", categoria.CategoriaId);                
                command.Parameters.AddWithValue("@eliminado", categoria.Eliminado);
                
                Methods.ExecuteBasicCommand(command); 
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("CategoriaDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("CategoriaDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Methods.GenerateLogsDebug("CategoriaDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar una categoria"));

        }
        /// <summary>
        /// Obtiene  la informacion de una categoria
        /// </summary>
        /// <param name="id">identificador de la categoria</param>
        /// <returns></returns>
        public static Categoria Get(int id)
        {
            Categoria res = new Categoria();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = "Select * From Categoria where CategoriaId = @id";
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = Methods.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Categoria()
                    {
                        CategoriaId = dr.GetInt32(0),
                        Nombre = dr.GetString(1),                        
                        Eliminado = dr.GetByte(2),                                                
                        //ProveedorId = ProveedorDal.Get(dr.GetInt32(7)),           
                    };
                }
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("CategoriaDal", "Obtener", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
