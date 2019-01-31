using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Comun;

namespace ClienteDal
{
    class ProveedorDal
    {

        /// <summary>
        /// Metodo que sirve para insertar un proveedor a la base de datos
        /// </summary>
        /// <param name="proveedor">Objeto paciente</param>
        public static void Insertar(Proveedor proveedor)
        {
            Methods.GenerateLogsDebug("ProveedorDal", "Insertar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para insertar un proveedor"));
            SqlCommand command = null;

            // Proporcionar la cadena de consulta
            string queryString = @"INSERT INTO Proveedor(NombreProveedor, ApellidoProveedor, CorreoElectronico, Eliminado)
                                    VALUES
                                    (@nombre, @apellido, @correo, @eliminado)";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@nombre", proveedor.NombreProveedor);
                command.Parameters.AddWithValue("@apellido", proveedor.ApellidoProveedor);

                command.Parameters.AddWithValue("@proveedorId", proveedor.ProveedorId);
                command.Parameters.AddWithValue("@correo", proveedor.CorreoElectronico);
                command.Parameters.AddWithValue("@eliminado", proveedor.Eliminado);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("ProveedorDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("ProveedorDal", "Insertar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            Methods.GenerateLogsDebug("ProveedorDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para insertar un proveedor"));
        }
        /// <summary>
        /// Eliminar proveedor
        /// </summary>
        /// <param name="id">Identificador del proveedor</param>
        public static void Eliminar(int id)
        {
            Methods.GenerateLogsDebug("ProveedorDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un proveedor"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = "UPDATE Proveedor SET Eliminado = 1 WHERE ProveedorId=@id";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@id", id);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("ProveedorDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("ProveedorDal", "Eliminar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            Methods.GenerateLogsDebug("ProveedorDal", "Eliminar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar el metodo acceso a base de datos para eliminar un proveedor"));

        }
        /// <summary>
        /// Actualiza los datos del proveedor en la base de datos
        /// </summary>
        /// <param name="proveedor"></param>
        public static void Actualizar(Proveedor proveedor)
        {
            Methods.GenerateLogsDebug("ProveedorDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToLongDateString(), "Empezando a ejecutar el metodo acceso a datos para Actualizar un proveedor"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta
            string queryString = @"UPDATE Proveedor SET NombreProveedor=@nombre, ApellidoProveedor=@apellido, CorreoElectronico=@correo, Eliminado= @eliminado Where ProveedorId=@proveedorId";
            try
            {
                command = Methods.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@proveedorId", proveedor.ProveedorId);
                command.Parameters.AddWithValue("@nombre", proveedor.NombreProveedor);
                command.Parameters.AddWithValue("@apellido", proveedor.ApellidoProveedor);
                command.Parameters.AddWithValue("@correo", proveedor.CorreoElectronico);
                command.Parameters.AddWithValue("@eliminado", proveedor.Eliminado);
                Methods.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("ProveedorDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("ProveedorDal", "Actualizar", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            Methods.GenerateLogsDebug("ProveedorDal", "Insertar", string.Format("{0} {1} Info: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "Termino de ejecutar  el metodo acceso a datos para Actualizar un proveedor"));
        }
        /// <summary>
        /// Obtine  la informacion de un proveedor
        /// </summary>
        /// <param name="id">identificador del proveedor</param>
        /// <returns></returns>
        public static Proveedor Get(int id)
        {
            Proveedor res = new Proveedor();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string queryString = "Select * From Proveedor where ProveedorId = @id";
            try
            {
                cmd = Methods.CreateBasicCommand(queryString);
                cmd.Parameters.AddWithValue("@id", id);
                dr = Methods.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Proveedor()
                    {
                        CorreoElectronico = dr.GetString(0),
                        NombreProveedor = dr.GetString(1),
                        ApellidoProveedor = dr.GetString(2),
                        Eliminado = dr.GetBoolean(3)
                    };
                }
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("ProveedorDal", "Obtener", string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
