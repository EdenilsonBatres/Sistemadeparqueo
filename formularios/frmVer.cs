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
    public partial class frmVer : Form
    {
        public frmVer()
        {
            InitializeComponent();
        }

        public clsManipulacionDatos DatosSeleccionados { get; set; }
       
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int placas = int.Parse(txtPlaca.Text);
                dgbMostrar.DataSource = clsMantenimiento.buscarInformacion(placas);

            }
            catch (Exception error)
            {
                MessageBox.Show("Solo se perminten numeros... "+error.Message);
            }
        }


        public void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgbMostrar.SelectedRows.Count == 1)
            {
                Int64 idN = Convert.ToInt64( dgbMostrar.CurrentRow.Cells[0].Value);
                DatosSeleccionados = clsMantenimiento.obtenerDatos(idN);

                if(DatosSeleccionados != null)
                {
                    frmMantenimiento objMantenimiento = new frmMantenimiento();

                    objMantenimiento.txtId.Text =Convert.ToString( DatosSeleccionados.Id); 
                    objMantenimiento.txtNombreMantenimiento.Text = DatosSeleccionados.NombreM;
                    objMantenimiento.txtApellidoMantenimiento.Text = DatosSeleccionados.ApellidoM;
                    objMantenimiento.txtNumeroLicenciaMant.Text = Convert.ToString(DatosSeleccionados.NumeroLicenciaM);
                    objMantenimiento.txtNumeroPlacaMant.Text = Convert.ToString(DatosSeleccionados.NumeroPlacaM);
                    objMantenimiento.txtColorMant.Text = DatosSeleccionados.ColorM;
                    objMantenimiento.txtTipoVehiculoMant.Text = DatosSeleccionados.TipoVehiculoM;
                    objMantenimiento.txtHoraEntradaMant.Text = DatosSeleccionados.HoraentradaM;
                    objMantenimiento.txtCantidadHorasMant.Text =Convert.ToString( DatosSeleccionados.HorasEstacioandoM);
                    objMantenimiento.txtTarifaHoraMant.Text = Convert.ToString(DatosSeleccionados.TarifaHoraM);
                    
                   // MessageBox.Show(Convert.ToString(DatosSeleccionados.NombreM));
                    objMantenimiento.Show();

                }
                else
                {
                    MessageBox.Show("no se estan recibiendo los datos");
                }

                

               

              
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun registro");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
