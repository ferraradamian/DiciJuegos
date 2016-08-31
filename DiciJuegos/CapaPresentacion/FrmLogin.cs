using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (NUsuarios.Autentificar(txtUsuario.Text, txtContraseña.Text))
            {
                MessageBox.Show("Gracias Por Loguearse;" + txtUsuario.Text);
            }            
            else
                MessageBox.Show("Error en los datos");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //{
            //    if (UsuarioDAL.Autentificar(txtUsuario.Text, txtContraseña.Text) > 0)
            //    {
            //        this.Hide();
            //        Form1 f = new Form1();
            //        f.ShowDialog();
            //    }
            //    else
            //        MessageBox.Show("Error en los datos");

            //}
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }
    }
}
