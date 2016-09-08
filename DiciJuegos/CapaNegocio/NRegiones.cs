using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NRegiones
    {
        public static bool AgregarRegion(String pRegion)
        {
            bool existe = false;
            List<DRegiones> listReg = new List<DRegiones>();
            listReg = DRegiones.ObtenerRegiones();
            if (listReg.Count() != 0)
            {
                foreach (var item in listReg)
                {
                    //buscar si el usuario existe
                    if (item.Region == pRegion)
                    {
                        existe = false;
                        break;
                    }
                    else
                    {
                        DRegiones.InsertarRegion(pRegion);
                        existe = true;
                        break;
                    }
                }
            }
            else
            {
                DRegiones.InsertarRegion(pRegion);
                existe = true;
            }
            return existe;
        }

        public static List<String> obtenerRegiones()
        {
            List<String> Regs = new List<String>();
            List<DRegiones> listReg = new List<DRegiones>();
            listReg = DRegiones.ObtenerRegiones();
            foreach (var item in listReg)
            {
                Regs.Add(item.Region);
            }
            return Regs;
        }

        public static bool ModificarRegion(String pRegionNueva, String pRegionActual)
        {
            return DRegiones.EditarRegion(pRegionNueva, pRegionActual);
        }

        public static bool EliminarRegion(String pregion)
        {
            return DRegiones.DeleteRegion(pregion);
        }
    }
}
