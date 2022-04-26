using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class clsLogin
    {
        private string usuario;
        private string pass;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Pass { get => pass; set => pass = value; }

        public clsLogin()
            {

            }

        public clsLogin(string pUsuario, string pPass)
        {
            this.Usuario = pUsuario;
            this.Pass = pPass;
        }

    }
}
