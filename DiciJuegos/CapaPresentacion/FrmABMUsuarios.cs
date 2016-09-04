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
    public partial class FrmABMUsuarios : Form
    {
        public FrmABMUsuarios()
        {
            InitializeComponent();
            TxtNombre.Select();
            RbAgregar.Checked = true;
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiar()
        {
            TxtNombre.Text = "";
            TxtPassword.Text = "";
            CBPerfil.Text = "Administrador";
            txtCodigo.Text = "";
            TxtBuscar.Text = "";
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            if (!validacionCampos())
            {
                return;
            }            
            try
            {
                var nom = TxtNombre.Text.Trim();
                var pass = TxtPassword.Text.Trim();
                var per = CBPerfil.Text.Trim();


                if (NUsuarios.AgregarUsuario(nom, pass, per)) //si la funcion agregar pudo insertar
                {
                    MessageBox.Show("Usuario Registrado Correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else//si no pudo insertar
                {
                    MessageBox.Show("Usuario No Fue Registrado o Ya Existe", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool validacionCampos()
        {
            if (this.TxtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Nombre", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.TxtNombre.Select();
                return false;
            }
            if (this.TxtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Contraseña", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.TxtPassword.Select();
                return false;
            }
            return true;
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            if (!validacionCampos())
            {
                return;
            }
            try
            {
                int id = Convert.ToInt32(txtCodigo.Text.Trim());
                var nom = TxtNombre.Text.Trim();
                var pass = TxtPassword.Text.Trim();
                var per = CBPerfil.Text.Trim();
                
                if (NUsuarios.ModificarUsuario(id,nom, pass, per)) 
                {
                    MessageBox.Show("Usuario Editado Correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("El Usuario No Pudo Ser Editado", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void RbAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (RbAgregar.Checked)
            {
                limpiar();
                BtLupa.Enabled = false;
                BtModificar.Enabled = false;
                BtEliminar.Enabled = false;
                BtAgregar.Enabled = true;

                TxtBuscar.Enabled = false;
                TxtNombre.Enabled = true;
                TxtPassword.Enabled = true;
                CBPerfil.Enabled = true;

                txtCodigo.Visible = false;
                LbCodigo.Visible = false;
            }
            
        }

        private void RbModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (RbModificar.Checked)
            {
                limpiar();
                BtLupa.Enabled = true;
                BtModificar.Enabled = true;
                BtEliminar.Enabled = false;
                BtAgregar.Enabled = false;

                TxtBuscar.Enabled = true;
                TxtNombre.Enabled = true;
                TxtPassword.Enabled = true;
                CBPerfil.Enabled = true;

                txtCodigo.Visible = true;
                LbCodigo.Visible = true;
            }
        }

        private void RbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (RbEliminar.Checked)
            {
                limpiar();
                BtLupa.Enabled = true;
                BtModificar.Enabled = false;
                BtEliminar.Enabled = true;
                BtAgregar.Enabled = false;

                TxtBuscar.Enabled = true;
                TxtNombre.Enabled = false;
                TxtPassword.Enabled = false;
                CBPerfil.Enabled = false;

                txtCodigo.Visible = true;
                LbCodigo.Visible = true;
            }            
        }

        private void BtLupa_Click(object sender, EventArgs e)
        {
            if (!(TxtBuscar.Text == ""))
            {
                Dictionary<String, String> UsuarioEncontrado = new Dictionary<String, String>();
                UsuarioEncontrado = NUsuarios.BuscarUsuario(TxtBuscar.Text);

                if (UsuarioEncontrado.Any())
                {
                    txtCodigo.Text = UsuarioEncontrado["Id"].ToString();
                    TxtNombre.Text = UsuarioEncontrado["Nombre"].ToString();
                    TxtPassword.Text = UsuarioEncontrado["Password"].ToString();
                    CBPerfil.Text = UsuarioEncontrado["Perfil"].ToString();

                }
                else
                {
                    MessageBox.Show("Usuario No Encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtLupa.PerformClick();
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
            {
                if (NUsuarios.EliminarUsuario(Convert.ToInt32(txtCodigo.Text)))
                {
                    MessageBox.Show("Usuario Eliminado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("El Usuario No Pudo Ser Eliminado", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe Buscar el Esuario a Eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
