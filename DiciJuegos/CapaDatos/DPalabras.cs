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
    }
}
