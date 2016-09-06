using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NCategorias
    {
        public static bool AgregarCategoria(String pCategoria)
        {
            bool existe = false;
            List<DCategorias> listCat = new List<DCategorias>();
            listCat = DCategorias.ObtenerCategorias();
            if (listCat.Count() != 0)
            {
                foreach (var item in listCat)
                {
                    //buscar si el usuario existe
                    if (item.Categoria == pCategoria)
                    {
                        existe = false;
                        break;
                    }
                    else
                    {
                        DCategorias.InsertarCategoria(pCategoria);
                        existe = true;
                        break;
                    }
                }
            }
            else
            {
                DCategorias.InsertarCategoria(pCategoria);
                existe = true;
            }
            return existe;
        }

        public static List<String> obtenerCategorias()
        {
            List<String> Cats = new List<String>();
            List<DCategorias> listCat = new List<DCategorias>();
            listCat = DCategorias.ObtenerCategorias();
            foreach (var item in listCat)
            {
                Cats.Add(item.Categoria);
            }
            return Cats;
           
        }
    }
}
