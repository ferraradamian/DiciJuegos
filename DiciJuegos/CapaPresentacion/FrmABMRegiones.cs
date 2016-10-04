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
    public partial class FrmABMRegiones : Form
    {
        public FrmABMRegiones()
        {
            InitializeComponent();
            txtRegion.Select();
            cargarRegiones();
            ChlbRegiones.SelectionMode = SelectionMode.One;
            BtAgregar.Enabled = true;
            BtModificar.Enabled = false;
            BtEliminar.Enabled = false;

        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        {
            txtRegion.Text = "";
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtRegion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese la region", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtRegion.Select();
                return;
            }
            try
            {
                var cat = txtRegion.Text.Trim();
                if (NRegiones.AgregarRegion(cat)) //si la funcion agregar pudo insertar
                {
                    MessageBox.Show("Region Registrada Correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    ChlbRegiones.Items.Clear();
                    cargarRegiones();
                }
                else//si no pudo insertar
                {
                    MessageBox.Show("La Region no Fue Registrada o Ya Existe", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cargarRegiones()
        {
            List<String> categorias = new List<String>();
            categorias = NRegiones.obtenerRegiones();

            foreach (var item in categorias)
            {
                ChlbRegiones.Items.Add(item);
            }
        }

        private void ChlbCategorias_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < ChlbRegiones.Items.Count; ++ix)
                if (ix != e.Index) ChlbRegiones.SetItemChecked(ix, false);
            if ((ChlbRegiones.CheckedItems.Count == 0))
            {
                txtRegion.Text = ChlbRegiones.Text;
                BtAgregar.Enabled = false;
                BtModificar.Enabled = true;
                BtEliminar.Enabled = true;
            }
            else
            {
                txtRegion.Text = "";
                BtAgregar.Enabled = true;
                BtModificar.Enabled = false;
                BtEliminar.Enabled = false;
            }

        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtRegion.Text) && !String.IsNullOrEmpty(ChlbRegiones.Text) && (txtRegion.Text != ChlbRegiones.Text))
            {
                if (NRegiones.ModificarRegion(txtRegion.Text, ChlbRegiones.Text))
                {
                    MessageBox.Show("Region Modificada Correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    ChlbRegiones.Items.Clear();
                    cargarRegiones();
                    BtAgregar.Enabled = true;
                    BtModificar.Enabled = false;
                    BtEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("La Region no pudo ser Modificada", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Region y Modificarla", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ChlbRegiones.Text))
            {
                if (NRegiones.EliminarRegion(ChlbRegiones.Text))
                {
                    MessageBox.Show("Region Eliminada Correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    ChlbRegiones.Items.Clear();
                    cargarRegiones();
                    BtAgregar.Enabled = true;
                    BtModificar.Enabled = false;
                    BtEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("La Region no pudo ser eliminada", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Region para Eliminar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmABMRegiones_Load(object sender, EventArgs e)
        {

        }
    }
}
