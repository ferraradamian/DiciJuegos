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
            this.Palabra = pPalabra;
            this.Definicion = pDefinicion;
            this.Imagen = pImagen;
            this.Seña = pSeña;
            this.Region = pRegion;
            this.Categoria = pCategoria;
        }

        public static bool InsertarPalabra(String pPalabra, String pDefinicion, String pImagen, String pSeña, List<string> pRegion, List<string> pCategoria)
        {
            try
            {  
                SqlCommand Insert = new SqlCommand("InsertPalabras", DConexion.ObtnerConexion());
                Insert.CommandType = CommandType.StoredProcedure;
                Insert.Parameters.Add("@Palabra", SqlDbType.VarChar, 30).Value = pPalabra;
                Insert.Parameters.Add("@Definicion", SqlDbType.VarChar, 500).Value = pDefinicion; 
                Insert.Parameters.Add("@imagen", SqlDbType.VarChar, 300).Value = pImagen;
                int r = Insert.ExecuteNonQuery();
                Insert.Connection.Close();

                foreach (var item in pCategoria)
                {
                    SqlCommand RelCategoriaPalabra = new SqlCommand("InsertRelCategoriaPalabra", DConexion.ObtnerConexion());
                    RelCategoriaPalabra.CommandType = CommandType.StoredProcedure;
                    RelCategoriaPalabra.Parameters.Add("@Palabra", SqlDbType.VarChar, 20).Value = pPalabra;
                    RelCategoriaPalabra.Parameters.Add("@categoria", SqlDbType.VarChar, 20).Value = item;                   

                    r = RelCategoriaPalabra.ExecuteNonQuery();
                    RelCategoriaPalabra.Connection.Close();
                }

                foreach (var item in pRegion)
                {
                    SqlCommand InsertSenia = new SqlCommand("InsertSenia", DConexion.ObtnerConexion());
                    InsertSenia.CommandType = CommandType.StoredProcedure;
                    InsertSenia.Parameters.Add("@Palabra", SqlDbType.VarChar, 20).Value = pPalabra;
                    InsertSenia.Parameters.Add("@Region", SqlDbType.VarChar, 20).Value = item;
                    InsertSenia.Parameters.Add("@senia", SqlDbType.VarChar, 300).Value = pSeña;
                    r = InsertSenia.ExecuteNonQuery();
                    InsertSenia.Connection.Close();
                }  

                return (r > 0);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DPalabras PalabraRandom(String pPalabra, String pCategoria, String pRegion)
        {
            DPalabras palabra = new DPalabras();
            try
            {
                SqlCommand obtenerPalabraRandom = new SqlCommand("PalabraRandom", DConexion.ObtnerConexion());
                obtenerPalabraRandom.CommandType = CommandType.StoredProcedure;
                obtenerPalabraRandom.Parameters.Add("@palabra", SqlDbType.VarChar, 30).Value = pPalabra;
                obtenerPalabraRandom.Parameters.Add("@categoria", SqlDbType.VarChar, 500).Value = pCategoria;
                obtenerPalabraRandom.Parameters.Add("@region", SqlDbType.VarChar, 300).Value = pRegion;
                SqlDataReader rdr = obtenerPalabraRandom.ExecuteReader(CommandBehavior.CloseConnection);
                rdr.Read();
                palabra.Palabra = rdr.GetString(0);
                palabra.Definicion = rdr.GetString(1);
                palabra.Imagen = rdr.GetString(2);
                palabra.Seña = rdr.GetString(3);
                palabra.Categoria = rdr.GetString(4);
                palabra.Region = rdr.GetString(5);
                return palabra;
            }
            catch(Exception)
            {
                return palabra;
            }
        }



    }
}
