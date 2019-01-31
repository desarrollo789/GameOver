using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun;

namespace ClienteDal
{
    class ProveedorListDal
    {

        public static ProveedorList Get()
        {
            ProveedorList res = new ProveedorList();

            SqlCommand cmd = null;
            SqlDataReader dr = null;

            string query = "SELECT * FROM Proveedor";
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                dr = Methods.ExecuteDataReaderCommand(cmd);

                while (dr.Read())
                {
                    int idProveedor = dr.GetInt32(1);
                    Proveedor proveedor = ProveedorDal.Get(idProveedor);

                    res.Add(new Proveedor()
                    {
                        ProveedorId = idProveedor,
                        NombreProveedor = proveedor.NombreProveedor,
                        ApellidoProveedor = proveedor.ApellidoProveedor,
                        CorreoElectronico = proveedor.ApellidoProveedor,
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
