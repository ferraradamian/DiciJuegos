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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void PContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PContenedor.Controls.Clear();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();           
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMUsuarios frmAbmUsuarios = new FrmABMUsuarios();
            frmAbmUsuarios.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMCategorias frmAbmCategorias= new FrmABMCategorias();
            frmAbmCategorias.ShowDialog();
        }

        private void regionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMRegiones frmAbmRegiones = new FrmABMRegiones();
            frmAbmRegiones.ShowDialog();
        }

        private void palabrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMPalabras frmAbmPalabras = new FrmABMPalabras();
            frmAbmPalabras.ShowDialog();
        }

        private void configuracToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PContenedor.Controls.Clear();
            FrmConfiguracion frmComfiguracion = new FrmConfiguracion();
            frmComfiguracion.ShowDialog();
        }

        private void CreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creditos controlCreditos = new Creditos();
            this.PContenedor.Controls.Clear();
            this.PContenedor.Controls.Add(controlCreditos);
        }

        private void aBMsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PContenedor.Controls.Clear();
        }

        private void ranaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JuegoRana controlJuegoRana = new JuegoRana();
            this.PContenedor.Controls.Clear();
            this.PContenedor.Controls.Add(controlJuegoRana);
        }

        private void diccionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PContenedor.Controls.Clear();
        }

        private void adivinarPalabraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdivinarPalabra controlAdivinarPalabra = new AdivinarPalabra();
            this.PContenedor.Controls.Clear();
            this.PContenedor.Controls.Add(controlAdivinarPalabra);
        }
    }
}
