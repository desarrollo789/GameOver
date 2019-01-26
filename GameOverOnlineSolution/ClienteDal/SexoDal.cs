using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Comun;

namespace ClienteDal
{
    /// <summary>
    /// Clase sexo para acceder a la base de datos
    /// </summary>
    class SexoDal
    {
        /// <summary>
        /// Obtener un sexo
        /// </summary>
        /// <param name="id">Identificador del sexo</param>
        /// <returns></returns>
        public static Sexo Get(byte id)
        {
            Sexo res = new Sexo();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = "Select * From Sexos where SexoId = @id";
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = Methods.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    cmd = Methods.CreateBasicCommand(query);
                    cmd.Parameters.AddWithValue("@id", id);
                    dr = Methods.ExecuteDataReaderCommand(cmd);
                };
            }
            catch (Exception ex)
            {
                res = new.Sexo
            }
        }
    }
}
