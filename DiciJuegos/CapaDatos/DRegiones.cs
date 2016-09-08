using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DRegiones
    {
        public int Id { set; get; }
        public String Region { set; get; }

        public DRegiones()
        {

        }

        public DRegiones(int pId, String pRegion)
        {
            this.Id = pId;
            this.Region = pRegion;
        }

        public static List<DRegiones> ObtenerRegiones()
        {
            List<DRegiones> LRegiones = new List<DRegiones>();

            SqlConnection conexion = DConexion.ObtnerConexion();

            SqlCommand command = new SqlCommand("SelectRegiones", conexion);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                DRegiones Region = new DRegiones();
                Region.Id = Convert.ToInt32(reader["Id"].ToString());
                Region.Region = reader["Region"].ToString();
                LRegiones.Add(Region);
            }
            conexion.Close();
            return LRegiones;
        }

        public static bool InsertarRegion(String pRegion)
        {
            SqlCommand sql = new SqlCommand("InsertRegiones", DConexion.ObtnerConexion());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.Add("@Region", SqlDbType.VarChar, 20).Value = pRegion;
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

        public static bool EditarRegion(String pRegNueva, String pRegActual)
        {
            SqlCommand sql = new SqlCommand("EditarRegiones", DConexion.ObtnerConexion());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.Add("@RegionNueva", SqlDbType.VarChar, 20).Value = pRegNueva;
            sql.Parameters.Add("@RegionActual", SqlDbType.VarChar, 20).Value = pRegActual;
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

        public static bool DeleteRegion(String pRegion)
        {
            SqlCommand sql = new SqlCommand("DeleteRegiones", DConexion.ObtnerConexion());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.Add("@Region", SqlDbType.VarChar, 20).Value = pRegion;
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
