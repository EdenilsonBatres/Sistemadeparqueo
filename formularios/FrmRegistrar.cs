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
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
         
            
                clsRegistrar objRegistrar = new clsRegistrar();
            try
            {
                objRegistrar.Nombre = txtNombreEncargado.Text;
                objRegistrar.Apellidos = txtApellidoEncargado.Text;
                objRegistrar.Licencia = int.Parse(txtNumeroLisencia.Text);

                objRegistrar.NumeroPlaca = int.Parse(txtNumeroPlaca.Text);
                objRegistrar.Color = Convert.ToString(cbColor.SelectedItem);
                objRegistrar.TipoVehiculo = Convert.ToString(cbTipoVehiculo.SelectedItem);
                objRegistrar.HoraEntrada = Convert.ToString(cbHoraEntrada.SelectedItem);
                objRegistrar.CantidadHoras = int.Parse(txtNumeroHoras.Text);
                objRegistrar.TarifaHora = double.Parse(txtTarifa.Text);

                int resultado = clsMantenimiento.agregarUsuarios(objRegistrar);
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
            catch( Exception error )
            {
                MessageBox.Show(error.Message);
                
            }



       
        }

       

        public void limpiar()
        {
            txtNombreEncargado.Clear();
            txtApellidoEncargado.Clear();
            txtNumeroLisencia .Clear();
            txtNumeroPlaca.Clear();
            cbColor.ResetText();
            cbTipoVehiculo.ResetText();
            cbHoraEntrada.ResetText();
            txtNumeroHoras.Clear();
            txtTarifa.Clear();

        }
    }
}
