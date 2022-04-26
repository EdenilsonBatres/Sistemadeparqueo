using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace formularios
{
    public partial class frmLogin : Form
    {
        clsMantenimientoLogin SQLcontrol = new clsMantenimientoLogin();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            frmNuevoLogin nuevoLogin = new frmNuevoLogin();
            nuevoLogin.Show();
        }

        

        private void btnIniciar_Click(object sender, EventArgs e)
        {
           try
            {
                clsLogin loginOb = new clsLogin();
                loginOb.Usuario = txtUsuario.Text;
                loginOb.Pass = txtPass.Text;

                int result = SQLcontrol.login(loginOb.Usuario, loginOb.Pass);

                if (result == 1)
                {
                    frmMenu menu = new frmMenu();
                    menu.Show();
                    this.Hide();
                }
                else if (result == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Trim() == "")
            {
                epError.SetError(txtUsuario, "Introduce tu Usuario...");
                txtUsuario.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtPass_Validated(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim() == "")
            {
                epError.SetError(txtPass, "Introduce tu contraseña...");
                txtPass.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
