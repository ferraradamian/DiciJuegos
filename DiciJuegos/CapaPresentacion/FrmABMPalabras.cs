using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmABMPalabras : Form
    {
        public FrmABMPalabras()
        {
            InitializeComponent();
            cargarRegiones();
            cargarCategorias();
            TxtPalabra.Select();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtPalabra.Text))
            {
                MessageBox.Show("Ingrese una palabra", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (!String.IsNullOrEmpty(TxtImagen.Text))
            {
                NPalabras.guardarArchivo(TxtImagen.Text);
            }
            if (!String.IsNullOrEmpty(TxtSeña.Text))
            {
                NPalabras.guardarArchivo(TxtSeña.Text);
            }
            List<string> regiones = new List<string>();
            if (ChlbRegiones.CheckedItems.Count > 0 )
            {                
                foreach (var item in ChlbRegiones.CheckedItems)
                {
                    regiones.Add(item.ToString());
                }
            }
            List<string> categorias = new List<string>();
            if (ChlbCategorias.CheckedItems.Count > 0)
            {
                
                foreach (var item in ChlbCategorias.CheckedItems)
                {
                    categorias.Add(item.ToString());
                }
            }
            if (NPalabras.agregarPalabra(TxtPalabra.Text,TxtDefinicion.Text,TxtImagen.Text,TxtSeña.Text, regiones,categorias))
            {
                MessageBox.Show("Palabra Cargada Correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else
            {
                MessageBox.Show("Error, la Palabra no Pudo ser Guardada", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarRegiones()
        {
            List<String> regiones = new List<String>();
            regiones = NRegiones.obtenerRegiones();

            foreach (var item in regiones)
            {
                ChlbRegiones.Items.Add(item);
            }
        }

        private void cargarCategorias()
        {
            List<String> categorias = new List<String>();
            categorias = NCategorias.obtenerCategorias();

            foreach (var item in categorias)
            {
                ChlbCategorias.Items.Add(item);
            }
        }

        private void limpiar()
        {
            TxtPalabra.Clear();
            TxtDefinicion.Clear();
            TxtImagen.Clear();
            TxtSeña.Clear();
            ChlbCategorias.ClearSelected();
            ChlbRegiones.ClearSelected();
        }


        private void BtModificar_Click(object sender, EventArgs e)
        {

        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
