using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class User
    {
        private string nombre;
        private string apellido;
        private int documento;
        private string role;
        private string contraseña;
        private string usuario;

        public User(string nombre, string apellido, int documento, string role, string contraseña, string usuario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
            this.role = role;
            this.contraseña = contraseña;
            this.usuario = usuario;
        }

        public string Mombre { get; }
        public string Apellido { get; }
        public int Documento { get; }
        public string Role { get; }
        public string Contraseña { get; }
        public string Usuario { get; }
    }
}
