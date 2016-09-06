using CapaNegocio;
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
    public partial class FrmABMCategorias : Form
    {
        public FrmABMCategorias()
        {
            InitializeComponent();
            TxtCategoria.Select();
            cargarCategorias();
            ChlbCategorias.SelectionMode = SelectionMode.One;
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        {
            TxtCategoria.Text = "";
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            if (this.TxtCategoria.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese la categotria", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.TxtCategoria.Select();
                return ;
            }
            try
            {
                var cat = TxtCategoria.Text.Trim();
                if (NCategorias.AgregarCategoria(cat)) //si la funcion agregar pudo insertar
                {
                    MessageBox.Show("Categoria Registrada Correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else//si no pudo insertar
                {
                    MessageBox.Show("La Categoria no Fue Registrada o Ya Existe", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        private void ChlbCategorias_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < ChlbCategorias.Items.Count; ++ix)
                if (ix != e.Index) ChlbCategorias.SetItemChecked(ix, false);
            if ((ChlbCategorias.CheckedItems.Count == 0))
            {
                TxtCategoria.Text = ChlbCategorias.Text;
            }
            else
            {
                TxtCategoria.Text = "";
            }

        }
    }
}
