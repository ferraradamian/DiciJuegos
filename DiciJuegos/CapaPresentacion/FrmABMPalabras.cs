using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmABMPalabras : Form
    {
        public FrmABMPalabras()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImag = new OpenFileDialog();
            BuscarImag.Filter = "Image Files(*.bmp, *.jpg, *png) | *.bmp; *.jpg; *png"; 

            if (BuscarImag.ShowDialog() == DialogResult.OK)
            {
                TxtImagen.Text = BuscarImag.FileName;
            }
        }

        private void BtnSeña_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarSeña = new OpenFileDialog();
            BuscarSeña.Filter = "Video Files(*.AVI, *.MPEG, *.MOV,*.MPEG4) | *.AVI; *.MPEG; *MOV;*.MPEG4";

            if (BuscarSeña.ShowDialog() == DialogResult.OK)
            {
                TxtSeña.Text = BuscarSeña.FileName;
            }
        }

        private void BtnModulacion_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarModulacion = new OpenFileDialog();
            BuscarModulacion.Filter = "Image Files(*.bmp, *.jpg, *png) | *.bmp; *.jpg; *png";

            if (BuscarModulacion.ShowDialog() == DialogResult.OK)
            {
                TxtModulacion.Text = BuscarModulacion.FileName;
            }
        }

        private void GbPalabra_Enter(object sender, EventArgs e)
        {

        }
    }
}
