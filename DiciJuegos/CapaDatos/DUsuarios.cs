using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DUsuarios
    {
        public int Id { set; get; }
        public String Nombre { set; get; }
        public String Password { set; get; }
        public String Perfil { set; get; }

        public DUsuarios()
        {

        }

        public DUsuarios(int pId, String pNombre, String pPassword, String pPerfil)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Password = pPassword;
            this.Perfil = pPerfil;
        }

        public static List<DUsuarios> Usuarios()
        {
            List<DUsuarios> LUsuarios = new List<DUsuarios>();
            
            SqlConnection conexion = DConexion.ObtnerConexion();

            SqlCommand command = new SqlCommand("SelectUsuarios", conexion);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = command.ExecuteReader();     

            while (reader.Read())
            {
                DUsuarios Usuario = new DUsuarios();
                Usuario.Id = Convert.ToInt32(reader["Id"].ToString());
                Usuario.Nombre = reader["Nombre"].ToString();
                Usuario.Password = reader["Password"].ToString();
                Usuario.Perfil = reader["Perfil"].ToString();
                LUsuarios.Add(Usuario);
            }
            conexion.Close();
            return LUsuarios;
        }

        public static bool InsertarUsuario(String pNombre, String pPassword, String pPerfil)
        {

            SqlCommand sql = new SqlCommand("InsertUsuarios", DConexion.ObtnerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20).Value = pNombre;
            sql.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = pPassword;
            sql.Parameters.Add("@Perfil", SqlDbType.VarChar, 15).Value = pPerfil;

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


        public static bool EditarUsuario(int pId,String pNombre, String pPassword, String pPerfil)
        {

            SqlCommand sql = new SqlCommand("EditarUsuarios", DConexion.ObtnerConexion());
            sql.CommandType = CommandType.StoredProcedure;

            sql.Parameters.Add("@Id", SqlDbType.Int).Value = pId;
            sql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20).Value = pNombre;
            sql.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = pPassword;
            sql.Parameters.Add("@Perfil", SqlDbType.VarChar, 15).Value = pPerfil;

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

        public static bool DeleteUsuario(int pId)
        {
            SqlCommand sql = new SqlCommand("DeleteUsuarios", DConexion.ObtnerConexion());
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
