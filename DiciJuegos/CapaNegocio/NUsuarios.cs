using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NUsuarios
    {
        public static bool Autentificar(String pUsuario, String pPassword, String pPerfil)
        {
            bool autenticado = false;

            List<DUsuarios> listUser = new List<DUsuarios>();
            listUser = DUsuarios.Usuarios();
            foreach (var item in listUser)
            {
                if (item.Nombre == pUsuario && item.Password == pPassword && item.Perfil == pPerfil)
                {
                    autenticado = true;
                    break;
                }
            }
            
            return autenticado;
        }

        public static bool AgregarUsuario(String pUsuario, String pPassword, String pPerfil)
        {
            bool insertado = false;           
   
            
            List<DUsuarios> listUser = new List<DUsuarios>();
            listUser = DUsuarios.Usuarios();

            if (listUser.Count() != 0)
            {        
                foreach (var item in listUser)
                {
                    //buscar si el usuario existe
                    if (item.Nombre == pUsuario)
                    {
                        insertado = false;
                        break;
                    }
                    else
                    {
                        // inserta el usuario en BD
                        DUsuarios.InsertarUsuario(pUsuario, pPassword, pPerfil);
                        insertado = true;
                        break;
                    }
                }
            }
            else {
                DUsuarios.InsertarUsuario(pUsuario, pPassword, pPerfil);
            }
            return insertado;
        }

        public static bool ModificarUsuario(int pId,String pUsuario, String pPassword, String pPerfil)
        {          
            return DUsuarios.EditarUsuario(pId, pUsuario, pPassword, pPerfil);
        }

        public static bool EliminarUsuario(int pId)
        {
            return DUsuarios.DeleteUsuario(pId);
        }

        public static Dictionary<String, String> BuscarUsuario(String pUsuario)
        {
            Dictionary<String, String> User =new Dictionary<String, String>();

            
            List<DUsuarios> listUser = new List<DUsuarios>();
            listUser = DUsuarios.Usuarios();
            foreach (var item in listUser)
            {
                //buscar si el usuario existe
                if (item.Nombre == pUsuario)
                {
                    User.Add("Id", item.Id.ToString());
                    User.Add("Nombre", item.Nombre);
                    User.Add("Password", item.Password);
                    User.Add("Perfil", item.Perfil);
                    break;
                }
            }
            return User;
        }
    }
}