using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Comun;
using ClienteDal;

namespace ClienteBrl
{
    public class CategoriaBrl
    {
        /// <summary>
        /// Metodo para Insertar una Categoria
        /// </summary>
        /// <param name="categoria"></param>
        public static void Insertar(Categoria categoria)
        {
            try
            {
                CategoriaDal.Insertar(categoria);
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
        }
        /// <summary>
        /// Metodo para Obtener una Categoria
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Categoria Get(int id)
        {
            Categoria categoria = null;
            try
            {
                categoria = CategoriaDal.Get(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categoria;
        }
        /// <summary>
        /// actualiza una Categoria
        /// </summary>
        /// <param name="categoria"></param>

        public static void Actualizar(Categoria categoria)
        {
            try
            {
                CategoriaDal.Actualizar(categoria);
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
        }

        /// <summary>
        /// Metodo para eliminar logicamente una Categoria
        /// </summary>
        /// <param name="id"></param>

        public static void Eliminar(int id)
        {
            try
            {
                CategoriaDal.Eliminar(id);
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

        }
        /// <summary>
        /// Metodo para obtener una lista de categoria de la base de datos
        /// </summary>
        /// <returns>List<Cliente></returns>

        public static List<Categoria> ListCategoria()
        {
            List<Categoria> categorias = null;
            try
            {
                categorias = CategoriaListDal.Get();
            }
            catch (SqlException ex)
            {
                Methods.GenerateLogsRelease("CategoriaBrl", "ListCategoria",
                string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(),
                DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Methods.GenerateLogsRelease("CategoriaBrl", "ListCategoria", string.Format("{0} {1} Error: {2}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            return categorias;

        }


    }
}
