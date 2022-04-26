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
    public partial class frmFlujo : Form
    {
        public frmFlujo()
        {
            InitializeComponent();

          
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            
            string parametro = Convert.ToString(cbTiempo.SelectedItem);
           if(parametro == "Diario")
            {
                MessageBox.Show("Parametro seleccionado :"+parametro);

                int identificador = 1;
                dgbFlujo.DataSource = clsMantenimiento.obtenerFlujo(identificador);
              

            }
           else if(parametro == "Semanal")
            {
                MessageBox.Show("Parametro seleccionado :"+parametro);

                int identificador = 2;
                dgbFlujo.DataSource = clsMantenimiento.obtenerFlujo(identificador);
            }
           else if (parametro == "Mensual")
            {
               MessageBox.Show("Parametro seleccionado :"+parametro);

                int identificador = 3;
                dgbFlujo.DataSource = clsMantenimiento.obtenerFlujo(identificador);
            }
           else if (parametro == "Anual")
            {
                MessageBox.Show("Parametro seleccionado:"+parametro);

                int identificador = 4;
                dgbFlujo.DataSource = clsMantenimiento.obtenerFlujo(identificador);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReportes reporte = new frmReportes();
            reporte.Show();
        }
    }
}
