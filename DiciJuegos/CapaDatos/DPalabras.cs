using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DPalabras
    {
        public int Id_Palabra { set; get; }
        public String Palabra { set; get; }
        public String Imagen { set; get; }
        public String Seña { set; get; }
        public String Region { set; get; }
        public String Categoria { set; get; }
        public String Definicion { set; get; }
        public DPalabras()
        {

        }

        public DPalabras(int pId, String pPalabra,String pDefinicion, String pImagen, String pSeña, String pRegion, String pCategoria)
        {
            this.Id_Palabra = pId;
            this.Palabra = pPalabra;
            this.Definicion = pDefinicion;
            this.Imagen = pImagen;
            this.Seña = pSeña;
            this.Region = pRegion;
            this.Categoria = pCategoria;
        }

        public static bool InsertarPalabra(String pPalabra, String pDefinicion, String pImagen, String pSeña, List<string> pRegion, List<string> pCategoria)
        {
            SqlCommand sql = new SqlCommand("InsertPalabras", DConexion.ObtnerConexion());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.Add("@Palabra", SqlDbType.VarChar, 30).Value = pPalabra;
            sql.Parameters.Add("@Definicion", SqlDbType.VarChar, 200).Value = pImagen;
            sql.Parameters.Add("@imagen", SqlDbType.VarChar, 120).Value = pSeña;
            sql.Parameters.Add("@Region", SqlDbType.VarChar, 20).Value = pRegion;
            sql.Parameters.Add("@categoria", SqlDbType.VarChar, 20).Value = pCategoria;
            sql.Parameters.Add("@senia", SqlDbType.VarChar, 120).Value = pSeña;
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
