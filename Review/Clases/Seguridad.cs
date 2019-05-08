using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class Seguridad
    {
        public static int ValidaCredenciales(string usuario, string contraseña, List<User> lista)
        {
            int salida=0;

            foreach (User row in lista)
            {

                if (row.Usuario == usuario)
                {
                    salida = 1;

                    if(row.Contraseña == contraseña)
                    {
                        salida= 2;
                    }
                    else
                    {
                        salida =3;
                    }

                    break;
                }
            }

            return salida;
        }

        private static bool ValidaUsuario(string credencial, List<User> lista)
        {
            foreach (User row in lista)
            {
                if(row.Usuario == credencial)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool ValidaContraseña(string credencial, User usuario)
        {
            if (usuario.Contraseña == credencial)
            {
                return true;
            }
    
            return false;
        }
    }
}
