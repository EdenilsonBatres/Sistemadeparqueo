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
using System.Data.SqlClient;

namespace formularios
{
    public partial class frmNuevoLogin : Form
    {
        public frmNuevoLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsNuevoLogin nuevoLoginObj = new clsNuevoLogin();

            try
            {
                nuevoLoginObj.Nombre = txtNombreLogin.Text;
                nuevoLoginObj.Apellido = txtApellidoLogin.Text;
                nuevoLoginObj.Correo = txtEmail.Text;
                nuevoLoginObj.Pass = txtPass.Text;
                nuevoLoginObj.Usuario = txtVerUsuario.Text;

                if (nuevoLoginObj.Nombre == "")
                {
                    MessageBox.Show("Error, ingresa un Nombre");
                }
                else if (nuevoLoginObj.Apellido == "")
                {
                    MessageBox.Show("Error, ingresa un Apellido");
                }
                else if (nuevoLoginObj.Correo == "")
                {
                    MessageBox.Show("Error, ingresa un Correo");
                }
                else if (nuevoLoginObj.Pass == "")
                {
                    MessageBox.Show("Error, ingresa una contraseña");
                }
                else if (nuevoLoginObj.Usuario == "")
                {
                    MessageBox.Show("Error, ingresa un Usuario");
                }
                else
                {
                    int resultado = clsMantenimientoLogin.agregarNuevoLogin(nuevoLoginObj);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Datos guardados");
                        limpiar();

                    }
                    else
                    {
                        MessageBox.Show("No se pudieron guardar los datos");
                    }
                }


                
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

            
        }
        public void limpiar()
        {
            txtNombreLogin.Clear();
            txtApellidoLogin.Clear();
            txtEmail.Clear();
            txtPass.Clear();
            txtVerUsuario.Clear();
            this.Close();
        }
       
        

        
    }
}
