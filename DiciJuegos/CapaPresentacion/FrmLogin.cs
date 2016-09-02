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
            if (CBPerfil.Text != "Seleccionar" && txtUsuario.Text != "" && txtPassword.Text != "")
            {           
                if (NUsuarios.Autentificar(txtUsuario.Text, txtPassword.Text, CBPerfil.Text))
                {
                    this.Close();
                }
                else {
                    txtPassword.Focus();
                    txtPassword.Clear();
                    MessageBox.Show("Acceso denegado", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Mensaje", MessageBoxButtons.OK);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEntrar.PerformClick();
            }

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPassword.Focus();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Select();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
