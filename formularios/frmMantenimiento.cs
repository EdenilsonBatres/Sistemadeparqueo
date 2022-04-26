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
    public partial class frmMantenimiento : Form
    {
        public frmMantenimiento( )
        {
            InitializeComponent();

            
        }

       

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            clsManipulacionDatos manipulacionObj = new clsManipulacionDatos();

            try
            {
                manipulacionObj.Id = int.Parse(txtId.Text);
                manipulacionObj.NombreM = txtNombreMantenimiento.Text;
                manipulacionObj.ApellidoM = txtApellidoMantenimiento.Text;
                manipulacionObj.NumeroLicenciaM = int.Parse(txtNumeroLicenciaMant.Text);
                manipulacionObj.NumeroPlacaM = int.Parse(txtNumeroPlacaMant.Text);
                manipulacionObj.ColorM = txtColorMant.Text;
                manipulacionObj.TipoVehiculoM = txtTipoVehiculoMant.Text;
                manipulacionObj.HoraentradaM = txtHoraEntradaMant.Text;
                manipulacionObj.HorasEstacioandoM = int.Parse(txtCantidadHorasMant.Text);
                manipulacionObj.TarifaHoraM = double.Parse(txtTarifaHoraMant.Text);

                int resultado = clsMantenimiento.actualizarUsuarios(manipulacionObj);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos actualizados con exito");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudieron actualizar los datos");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
           
        }

        public void limpiar()
        {
            txtNombreMantenimiento.Clear();
            txtApellidoMantenimiento.Clear();
            txtNumeroLicenciaMant.Clear();
            txtNumeroPlacaMant.Clear();
            txtColorMant.ResetText();
            txtTipoVehiculoMant.ResetText();
            txtCantidadHorasMant.ResetText();
            txtHoraEntradaMant.Clear();
            txtTarifaHoraMant.Clear();
            txtId.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsManipulacionDatos datosObj = new clsManipulacionDatos();

        try
            {
                datosObj.Id = int.Parse(txtId.Text);

                int resultado = clsMantenimiento.eliminarUsuarios(datosObj);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Borrados de la existencia con exito");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudieron borrar los datos");
                }
            }
            catch( Exception error)
            {
                MessageBox.Show(error.Message);
            }
            


        }
    }
}
