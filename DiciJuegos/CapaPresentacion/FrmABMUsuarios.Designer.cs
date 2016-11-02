namespace CapaPresentacion
{
    partial class FrmABMUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMUsuarios));
            this.LBNombre = new System.Windows.Forms.Label();
            this.LBContraseña = new System.Windows.Forms.Label();
            this.LBPerfil = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.CBPerfil = new System.Windows.Forms.ComboBox();
            this.GbUsuarios = new System.Windows.Forms.GroupBox();
            this.LbCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtLupa = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PABMSelecionar = new System.Windows.Forms.Panel();
            this.RbAgregar = new System.Windows.Forms.RadioButton();
            this.RbEliminar = new System.Windows.Forms.RadioButton();
            this.RbModificar = new System.Windows.Forms.RadioButton();
            this.PbUsuario = new System.Windows.Forms.PictureBox();
            this.BtSalir = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtModificar = new System.Windows.Forms.Button();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.GbUsuarios.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PABMSelecionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // LBNombre
            // 
            this.LBNombre.AutoSize = true;
            this.LBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBNombre.ForeColor = System.Drawing.Color.Black;
            this.LBNombre.Location = new System.Drawing.Point(25, 205);
            this.LBNombre.Name = "LBNombre";
            this.LBNombre.Size = new System.Drawing.Size(69, 20);
            this.LBNombre.TabIndex = 1;
            this.LBNombre.Text = "Nombre:";
            // 
            // LBContraseña
            // 
            this.LBContraseña.AutoSize = true;
            this.LBContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBContraseña.ForeColor = System.Drawing.Color.Black;
            this.LBContraseña.Location = new System.Drawing.Point(25, 254);
            this.LBContraseña.Name = "LBContraseña";
            this.LBContraseña.Size = new System.Drawing.Size(96, 20);
            this.LBContraseña.TabIndex = 2;
            this.LBContraseña.Text = "Contraseña:";
            // 
            // LBPerfil
            // 
            this.LBPerfil.AutoSize = true;
            this.LBPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBPerfil.ForeColor = System.Drawing.Color.Black;
            this.LBPerfil.Location = new System.Drawing.Point(25, 298);
            this.LBPerfil.Name = "LBPerfil";
            this.LBPerfil.Size = new System.Drawing.Size(48, 20);
            this.LBPerfil.TabIndex = 3;
            this.LBPerfil.Text = "Perfil:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(138, 199);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(163, 26);
            this.TxtNombre.TabIndex = 5;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(138, 248);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(163, 26);
            this.TxtPassword.TabIndex = 6;
            // 
            // CBPerfil
            // 
            this.CBPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPerfil.FormattingEnabled = true;
            this.CBPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Docente"});
            this.CBPerfil.Location = new System.Drawing.Point(138, 295);
            this.CBPerfil.Name = "CBPerfil";
            this.CBPerfil.Size = new System.Drawing.Size(163, 23);
            this.CBPerfil.TabIndex = 7;
            this.CBPerfil.Text = "Administrador";
            // 
            // GbUsuarios
            // 
            this.GbUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.GbUsuarios.Controls.Add(this.LbCodigo);
            this.GbUsuarios.Controls.Add(this.txtCodigo);
            this.GbUsuarios.Controls.Add(this.panel2);
            this.GbUsuarios.Controls.Add(this.PABMSelecionar);
            this.GbUsuarios.Controls.Add(this.PbUsuario);
            this.GbUsuarios.Controls.Add(this.BtSalir);
            this.GbUsuarios.Controls.Add(this.BtEliminar);
            this.GbUsuarios.Controls.Add(this.BtModificar);
            this.GbUsuarios.Controls.Add(this.BtAgregar);
            this.GbUsuarios.Controls.Add(this.CBPerfil);
            this.GbUsuarios.Controls.Add(this.LBNombre);
            this.GbUsuarios.Controls.Add(this.TxtPassword);
            this.GbUsuarios.Controls.Add(this.LBContraseña);
            this.GbUsuarios.Controls.Add(this.TxtNombre);
            this.GbUsuarios.Controls.Add(this.LBPerfil);
            this.GbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbUsuarios.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GbUsuarios.Location = new System.Drawing.Point(12, 12);
            this.GbUsuarios.Name = "GbUsuarios";
            this.GbUsuarios.Size = new System.Drawing.Size(500, 455);
            this.GbUsuarios.TabIndex = 8;
            this.GbUsuarios.TabStop = false;
            this.GbUsuarios.Text = "Usuarios";
            this.GbUsuarios.Enter += new System.EventHandler(this.GbUsuarios_Enter);
            // 
            // LbCodigo
            // 
            this.LbCodigo.AutoSize = true;
            this.LbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbCodigo.ForeColor = System.Drawing.Color.Black;
            this.LbCodigo.Location = new System.Drawing.Point(25, 154);
            this.LbCodigo.Name = "LbCodigo";
            this.LbCodigo.Size = new System.Drawing.Size(63, 20);
            this.LbCodigo.TabIndex = 18;
            this.LbCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(138, 150);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(163, 26);
            this.txtCodigo.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtLupa);
            this.panel2.Controls.Add(this.TxtBuscar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(138, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 40);
            this.panel2.TabIndex = 17;
            // 
            // BtLupa
            // 
            this.BtLupa.BackColor = System.Drawing.Color.Transparent;
            this.BtLupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLupa.Image = ((System.Drawing.Image)(resources.GetObject("BtLupa.Image")));
            this.BtLupa.Location = new System.Drawing.Point(290, 5);
            this.BtLupa.Name = "BtLupa";
            this.BtLupa.Size = new System.Drawing.Size(37, 28);
            this.BtLupa.TabIndex = 15;
            this.BtLupa.UseVisualStyleBackColor = false;
            this.BtLupa.Click += new System.EventHandler(this.BtLupa_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBuscar.Location = new System.Drawing.Point(92, 6);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(192, 26);
            this.TxtBuscar.TabIndex = 14;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar:";
            // 
            // PABMSelecionar
            // 
            this.PABMSelecionar.BackColor = System.Drawing.Color.Transparent;
            this.PABMSelecionar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PABMSelecionar.Controls.Add(this.RbAgregar);
            this.PABMSelecionar.Controls.Add(this.RbEliminar);
            this.PABMSelecionar.Controls.Add(this.RbModificar);
            this.PABMSelecionar.Location = new System.Drawing.Point(7, 25);
            this.PABMSelecionar.Name = "PABMSelecionar";
            this.PABMSelecionar.Size = new System.Drawing.Size(125, 91);
            this.PABMSelecionar.TabIndex = 17;
            // 
            // RbAgregar
            // 
            this.RbAgregar.AutoSize = true;
            this.RbAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbAgregar.ForeColor = System.Drawing.Color.Black;
            this.RbAgregar.Location = new System.Drawing.Point(7, 6);
            this.RbAgregar.Name = "RbAgregar";
            this.RbAgregar.Size = new System.Drawing.Size(84, 24);
            this.RbAgregar.TabIndex = 14;
            this.RbAgregar.TabStop = true;
            this.RbAgregar.Text = "Agregar";
            this.RbAgregar.UseVisualStyleBackColor = true;
            this.RbAgregar.CheckedChanged += new System.EventHandler(this.RbAgregar_CheckedChanged);
            // 
            // RbEliminar
            // 
            this.RbEliminar.AutoSize = true;
            this.RbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbEliminar.ForeColor = System.Drawing.Color.Black;
            this.RbEliminar.Location = new System.Drawing.Point(7, 53);
            this.RbEliminar.Name = "RbEliminar";
            this.RbEliminar.Size = new System.Drawing.Size(83, 24);
            this.RbEliminar.TabIndex = 16;
            this.RbEliminar.TabStop = true;
            this.RbEliminar.Text = "Eliminar";
            this.RbEliminar.UseVisualStyleBackColor = true;
            this.RbEliminar.CheckedChanged += new System.EventHandler(this.RbEliminar_CheckedChanged);
            // 
            // RbModificar
            // 
            this.RbModificar.AutoSize = true;
            this.RbModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbModificar.ForeColor = System.Drawing.Color.Black;
            this.RbModificar.Location = new System.Drawing.Point(7, 29);
            this.RbModificar.Name = "RbModificar";
            this.RbModificar.Size = new System.Drawing.Size(91, 24);
            this.RbModificar.TabIndex = 15;
            this.RbModificar.TabStop = true;
            this.RbModificar.Text = "Modificar";
            this.RbModificar.UseVisualStyleBackColor = true;
            this.RbModificar.CheckedChanged += new System.EventHandler(this.RbModificar_CheckedChanged);
            // 
            // PbUsuario
            // 
            this.PbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.PbUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbUsuario.BackgroundImage")));
            this.PbUsuario.Location = new System.Drawing.Point(339, 195);
            this.PbUsuario.Name = "PbUsuario";
            this.PbUsuario.Size = new System.Drawing.Size(127, 133);
            this.PbUsuario.TabIndex = 12;
            this.PbUsuario.TabStop = false;
            // 
            // BtSalir
            // 
            this.BtSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtSalir.ForeColor = System.Drawing.Color.Black;
            this.BtSalir.Location = new System.Drawing.Point(374, 381);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(92, 53);
            this.BtSalir.TabIndex = 11;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = false;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtEliminar.Location = new System.Drawing.Point(252, 381);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(92, 53);
            this.BtEliminar.TabIndex = 10;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = false;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtModificar
            // 
            this.BtModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtModificar.ForeColor = System.Drawing.Color.Black;
            this.BtModificar.Location = new System.Drawing.Point(138, 381);
            this.BtModificar.Name = "BtModificar";
            this.BtModificar.Size = new System.Drawing.Size(92, 53);
            this.BtModificar.TabIndex = 9;
            this.BtModificar.Text = "Modificar";
            this.BtModificar.UseVisualStyleBackColor = false;
            this.BtModificar.Click += new System.EventHandler(this.BtModificar_Click);
            // 
            // BtAgregar
            // 
            this.BtAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtAgregar.Location = new System.Drawing.Point(29, 381);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(92, 53);
            this.BtAgregar.TabIndex = 8;
            this.BtAgregar.Text = "Agregar";
            this.BtAgregar.UseVisualStyleBackColor = false;
            this.BtAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // FrmABMUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.textura_1_celeste;
            this.ClientSize = new System.Drawing.Size(520, 479);
            this.ControlBox = false;
            this.Controls.Add(this.GbUsuarios);
            this.Name = "FrmABMUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.GbUsuarios.ResumeLayout(false);
            this.GbUsuarios.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PABMSelecionar.ResumeLayout(false);
            this.PABMSelecionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LBNombre;
        private System.Windows.Forms.Label LBContraseña;
        private System.Windows.Forms.Label LBPerfil;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.ComboBox CBPerfil;
        private System.Windows.Forms.GroupBox GbUsuarios;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button BtModificar;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.PictureBox PbUsuario;
        private System.Windows.Forms.Panel PABMSelecionar;
        private System.Windows.Forms.RadioButton RbAgregar;
        private System.Windows.Forms.RadioButton RbEliminar;
        private System.Windows.Forms.RadioButton RbModificar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtLupa;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}