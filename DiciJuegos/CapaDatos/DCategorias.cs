using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCategorias
    {
        public int Id { set; get; }
        public String Categoria { set; get; }

        public DCategorias()
        {

        }

        public DCategorias(int pId, String pCategoria)
        {
            this.Id = pId;
            this.Categoria = pCategoria;
        }

        public static List<DCategorias> ObtenerCategorias()
        {
            List<DCategorias> LCategorias = new List<DCategorias>();

            SqlConnection conexion = DConexion.ObtnerConexion();

            SqlCommand command = new SqlCommand("SelectCategorias", conexion);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                DCategorias Categoria = new DCategorias();
                Categoria.Id = Convert.ToInt32(reader["Id"].ToString());
                Categoria.Categoria = reader["Categoria"].ToString();
                LCategorias.Add(Categoria);
            }
            conexion.Close();
            return LCategorias;
        }

        public static bool InsertarCategoria(String pCategoria)
        {
            SqlCommand sql = new SqlCommand("InsertCategorias", DConexion.ObtnerConexion());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.Add("@Categoria", SqlDbType.VarChar, 20).Value = pCategoria;
            try
            {
                int r = sql.ExecuteNonQuery();
                sql.Connection.Close();
                return (r > 0);
            }
            catch (Exception)
            {
                sql.Connection.Close();
                return false;
            }
        }

        public static bool EditarCategoria(int pId, String pCategoria)
        {
            SqlCommand sql = new SqlCommand("EditarCategorias", DConexion.ObtnerConexion());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.Add("@Id", SqlDbType.Int).Value = pId;
            sql.Parameters.Add("@Categoria", SqlDbType.VarChar, 20).Value = pCategoria;
            try
            {
                int r = sql.ExecuteNonQuery();
                sql.Connection.Close();
                return (r > 0);
            }
            catch (Exception)
            {
                sql.Connection.Close();
                return false;
            }
        }

        public static bool DeleteCategoria(int pId)
        {
            SqlCommand sql = new SqlCommand("DeleteCategorias", DConexion.ObtnerConexion());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.Add("@Id", SqlDbType.Int).Value = pId;
            try
            {
                int r = sql.ExecuteNonQuery();
                sql.Connection.Close();
                return (r > 0);
            }
            catch (Exception)
            {
                sql.Connection.Close();
                return false;
            }
        }

    }
}
