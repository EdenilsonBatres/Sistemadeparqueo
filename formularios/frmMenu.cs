using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistrar registrar = new FrmRegistrar();
            registrar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVer ver = new frmVer();
            ver.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFlujo flujo = new frmFlujo();
            flujo.Show();
        }
    }
}
