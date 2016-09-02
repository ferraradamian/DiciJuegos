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
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();           
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMUsuarios frmAbmUsuarios = new FrmABMUsuarios();
            frmAbmUsuarios.ShowDialog();
        }
    }
}
