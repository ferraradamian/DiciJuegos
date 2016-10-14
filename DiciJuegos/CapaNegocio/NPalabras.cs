using CapaDatos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class NPalabras
    {
        private static string rutaSeña = null;
        private static string rutaImagen = null;
        public static void guardarArchivo(string pSourcePath)
        {
            string extension = null;
            string fileName = Path.GetFileName(pSourcePath); 
            string sourcePath = Path.GetDirectoryName(pSourcePath);
            string targetPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Archivos";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }
            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            File.Copy(sourceFile, destFile, true);

            extension = Path.GetExtension(destFile);
            if (extension == ".avi" || extension == ".mpeg" || extension == ".mov" || extension == ".mpge4" || extension == ".3gp")
            {
                rutaSeña = destFile;
            }
            if (extension == ".bmp" || extension == ".jpg" || extension == ".png")
            {
                rutaImagen = destFile;
            }
        }

        public static bool agregarPalabra(string pPalabra,string pDefinicion,string pImagen, string pSeña, List<string> pRegion,List<string> pCategoria)
        {
            bool result = DPalabras.InsertarPalabra(pPalabra, pDefinicion, rutaImagen, rutaSeña, pRegion, pCategoria);
            rutaSeña = null;
            rutaImagen = null;
            return result;
        }

        
    }
}
