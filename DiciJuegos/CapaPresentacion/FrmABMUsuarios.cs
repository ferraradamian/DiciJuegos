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

        private void RbAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (RbAgregar.Checked)
            {
                BtLupa.Enabled = false;
                BtModificar.Enabled = false;
                BtEliminar.Enabled = false;
                BtAgregar.Enabled = true;

                TxtBuscar.Enabled = false;
                TxtNombre.Enabled = true;
                TxtPassword.Enabled = true;
                CBPerfil.Enabled = true;
            }
            
        }

        private void RbModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (RbModificar.Checked)
            {
                BtLupa.Enabled = true;
                BtModificar.Enabled = true;
                BtEliminar.Enabled = false;
                BtAgregar.Enabled = false;

                TxtBuscar.Enabled = true;
                TxtNombre.Enabled = true;
                TxtPassword.Enabled = true;
                CBPerfil.Enabled = true;
            }
        }

        private void RbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (RbEliminar.Checked)
            {
                BtLupa.Enabled = true;
                BtModificar.Enabled = false;
                BtEliminar.Enabled = true;
                BtAgregar.Enabled = false;

                TxtBuscar.Enabled = true;
                TxtNombre.Enabled = false;
                TxtPassword.Enabled = false;
                CBPerfil.Enabled = false;
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

    }
}
