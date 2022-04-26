using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class clsNuevoLogin
    {
        private string nombre;
        private string apellido;
        private string correo;
        private string pass;
        private string usuario;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Usuario { get => usuario; set => usuario = value; }

        public clsNuevoLogin()
        {

        }

        public clsNuevoLogin(string pNombre, string pApellido, string pCorreo, string pPass, string pUsuario)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Correo = pCorreo;
            this.Pass = pPass;
            this.Usuario = pUsuario;

        }
    }
}
