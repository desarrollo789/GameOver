﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun;

namespace ClienteDal
{
    public class UsuarioListDal
    {
        public static UsuarioList Get()
        {
            UsuarioList res = new UsuarioList();

            SqlCommand cmd = null;
            SqlDataReader dr = null;

            string query = "SELECT * FROM Usuario";
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                dr = Methods.ExecuteDataReaderCommand(cmd);

                while (dr.Read())
                {
                    int idUsuario = dr.GetInt32(0);
                    Usuario usuario = UsuarioDal.Get(idUsuario);

                    res.Add(new Usuario()
                    {
                        UsuarioId = idUsuario,                        
                        Nombre = usuario.Nombre,
                        Apellido = usuario.Apellido,                        
                        Sexo = usuario.Sexo,
                        FechaNacimiento = usuario.FechaNacimiento,
                        CorreoElectronico = usuario.CorreoElectronico,
                        Username = usuario.Username,                           
                        Eliminado = usuario.Eliminado,                        
                        FechaIngreso = dr.GetDateTime(2),
                        Cargo = CargoDal.Get(dr.GetInt32(3)),
                        Sueldo = dr.GetSqlDecimal(4).ToDouble()
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