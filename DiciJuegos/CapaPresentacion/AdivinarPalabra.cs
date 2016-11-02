using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.IO;
using System.Threading;

namespace CapaPresentacion
{
    public partial class AdivinarPalabra : UserControl
    {
        string letra = null;
        string anteriorpalabra = null;
        public AdivinarPalabra()
        {
            InitializeComponent();
            cargarCategorias();
            cargarRegiones();
            TxtBxLetra.Select();
        }

        private void cargarRegiones()
        {
            List<String> regiones = new List<String>();
            regiones = NRegiones.obtenerRegiones();

            foreach (var item in regiones)
            {
                CmbxRegion.Items.Add(item);
            }
        }

        private void cargarCategorias()
        {
            List<String> categorias = new List<String>();
            categorias = NCategorias.obtenerCategorias();

            foreach (var item in categorias)
            {
                CmbCategoria.Items.Add(item);
            }
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CmbCategoria.Text) && !String.IsNullOrEmpty(CmbxRegion.Text))
            {
                BuscarPalabra();

            }
            else
            {
                MessageBox.Show("Debe Elegir una Categoria y una Region", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BuscarPalabra()
        {
            List<string> ValPalabra = new List<string>();
            string palabra = null;
            ValPalabra = NAdivinarPalabra.obtenerPalabraRandom("palabra", CmbCategoria.Text, CmbxRegion.Text);
            anteriorpalabra = ValPalabra[0].ToString();
            palabra = ValPalabra[0].ToString();
            Lblletra.Text = palabra.Substring(1);
            letra = palabra.Substring(0, 1);
            LblDefinicion.Text = ValPalabra[1].ToString();
            PctBxImagen.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, ValPalabra[2].ToString()));
            axWindowsMediaPlayer.URL = ValPalabra[3].ToString();
        }

        private void TxtBxLetra_KeyUp(object sender, KeyEventArgs e)
        {
            timer1.Start();
            if (TxtBxLetra.Text == letra)
            {                
                LbCorrecto.Text = "Correcto!";
                LbCorrecto.Visible = true;
                BuscarPalabra();
                LbCorrecto.Text = "";
            }
            else
            {
                LbCorrecto.Text = "Incorrecto!";
                LbCorrecto.Visible = true;
                letra = null;
                LbCorrecto.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LbCorrecto.Visible = false;
        }
    }
}
