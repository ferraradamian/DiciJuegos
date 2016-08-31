using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DConexion
    {

        public static SqlConnection ObtnerConexion()
        {
            SqlConnection CBDDiciJuegos = new SqlConnection("Data Source= DAMIAN-PC\\SQLEXPRESS; Initial Catalog= BDDicijuegos; Integrated Security= SSPI;");

            CBDDiciJuegos.Open();

            return CBDDiciJuegos;

        }
    }
}
