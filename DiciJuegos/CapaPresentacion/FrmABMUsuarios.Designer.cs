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
            this.LBCodigo = new System.Windows.Forms.Label();
            this.LBNombre = new System.Windows.Forms.Label();
            this.LBContraseña = new System.Windows.Forms.Label();
            this.LBPerfil = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TextContraseña = new System.Windows.Forms.TextBox();
            this.CBPerfil = new System.Windows.Forms.ComboBox();
            this.GbUsuarios = new System.Windows.Forms.GroupBox();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.BtModificar = new System.Windows.Forms.Button();
            this.BtEliminat = new System.Windows.Forms.Button();
            this.BtSalir = new System.Windows.Forms.Button();
            this.PanelBuscar = new System.Windows.Forms.Panel();
            this.LbBuscar = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtLupa = new System.Windows.Forms.Button();
            this.PbUsuario = new System.Windows.Forms.PictureBox();
            this.GbUsuarios.SuspendLayout();
            this.PanelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // LBCodigo
            // 
            this.LBCodigo.AutoSize = true;
            this.LBCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBCodigo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LBCodigo.Location = new System.Drawing.Point(25, 87);
            this.LBCodigo.Name = "LBCodigo";
            this.LBCodigo.Size = new System.Drawing.Size(63, 20);
            this.LBCodigo.TabIndex = 0;
            this.LBCodigo.Text = "Codigo:";
            // 
            // LBNombre
            // 
            this.LBNombre.AutoSize = true;
            this.LBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBNombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LBNombre.Location = new System.Drawing.Point(25, 139);
            this.LBNombre.Name = "LBNombre";
            this.LBNombre.Size = new System.Drawing.Size(69, 20);
            this.LBNombre.TabIndex = 1;
            this.LBNombre.Text = "Nombre:";
            // 
            // LBContraseña
            // 
            this.LBContraseña.AutoSize = true;
            this.LBContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBContraseña.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LBContraseña.Location = new System.Drawing.Point(25, 194);
            this.LBContraseña.Name = "LBContraseña";
            this.LBContraseña.Size = new System.Drawing.Size(96, 20);
            this.LBContraseña.TabIndex = 2;
            this.LBContraseña.Text = "Contraseña:";
            // 
            // LBPerfil
            // 
            this.LBPerfil.AutoSize = true;
            this.LBPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBPerfil.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LBPerfil.Location = new System.Drawing.Point(25, 243);
            this.LBPerfil.Name = "LBPerfil";
            this.LBPerfil.Size = new System.Drawing.Size(48, 20);
            this.LBPerfil.TabIndex = 3;
            this.LBPerfil.Text = "Perfil:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(138, 87);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(163, 26);
            this.TxtCodigo.TabIndex = 4;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(138, 141);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(163, 26);
            this.TxtNombre.TabIndex = 5;
            // 
            // TextContraseña
            // 
            this.TextContraseña.Location = new System.Drawing.Point(138, 194);
            this.TextContraseña.Name = "TextContraseña";
            this.TextContraseña.Size = new System.Drawing.Size(163, 26);
            this.TextContraseña.TabIndex = 6;
            // 
            // CBPerfil
            // 
            this.CBPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPerfil.FormattingEnabled = true;
            this.CBPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Docente"});
            this.CBPerfil.Location = new System.Drawing.Point(138, 241);
            this.CBPerfil.Name = "CBPerfil";
            this.CBPerfil.Size = new System.Drawing.Size(163, 23);
            this.CBPerfil.TabIndex = 7;
            this.CBPerfil.Text = "Administrador";
            this.CBPerfil.SelectedIndexChanged += new System.EventHandler(this.CBPerfil_SelectedIndexChanged);
            // 
            // GbUsuarios
            // 
            this.GbUsuarios.Controls.Add(this.PanelBuscar);
            this.GbUsuarios.Controls.Add(this.PbUsuario);
            this.GbUsuarios.Controls.Add(this.BtSalir);
            this.GbUsuarios.Controls.Add(this.BtEliminat);
            this.GbUsuarios.Controls.Add(this.BtModificar);
            this.GbUsuarios.Controls.Add(this.BtAgregar);
            this.GbUsuarios.Controls.Add(this.LBCodigo);
            this.GbUsuarios.Controls.Add(this.CBPerfil);
            this.GbUsuarios.Controls.Add(this.LBNombre);
            this.GbUsuarios.Controls.Add(this.TextContraseña);
            this.GbUsuarios.Controls.Add(this.LBContraseña);
            this.GbUsuarios.Controls.Add(this.TxtNombre);
            this.GbUsuarios.Controls.Add(this.LBPerfil);
            this.GbUsuarios.Controls.Add(this.TxtCodigo);
            this.GbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbUsuarios.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GbUsuarios.Location = new System.Drawing.Point(13, 13);
            this.GbUsuarios.Name = "GbUsuarios";
            this.GbUsuarios.Size = new System.Drawing.Size(500, 374);
            this.GbUsuarios.TabIndex = 8;
            this.GbUsuarios.TabStop = false;
            this.GbUsuarios.Text = "Usuarios";
            // 
            // BtAgregar
            // 
            this.BtAgregar.Location = new System.Drawing.Point(29, 299);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(92, 53);
            this.BtAgregar.TabIndex = 8;
            this.BtAgregar.Text = "Agregar";
            this.BtAgregar.UseVisualStyleBackColor = false;
            // 
            // BtModificar
            // 
            this.BtModificar.Location = new System.Drawing.Point(138, 299);
            this.BtModificar.Name = "BtModificar";
            this.BtModificar.Size = new System.Drawing.Size(92, 53);
            this.BtModificar.TabIndex = 9;
            this.BtModificar.Text = "Modificar";
            this.BtModificar.UseVisualStyleBackColor = false;
            // 
            // BtEliminat
            // 
            this.BtEliminat.Location = new System.Drawing.Point(252, 299);
            this.BtEliminat.Name = "BtEliminat";
            this.BtEliminat.Size = new System.Drawing.Size(92, 53);
            this.BtEliminat.TabIndex = 10;
            this.BtEliminat.Text = "Eliminar";
            this.BtEliminat.UseVisualStyleBackColor = false;
            // 
            // BtSalir
            // 
            this.BtSalir.Location = new System.Drawing.Point(374, 299);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(92, 53);
            this.BtSalir.TabIndex = 11;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = false;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // PanelBuscar
            // 
            this.PanelBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBuscar.Controls.Add(this.BtLupa);
            this.PanelBuscar.Controls.Add(this.TxtBuscar);
            this.PanelBuscar.Controls.Add(this.LbBuscar);
            this.PanelBuscar.Location = new System.Drawing.Point(138, 25);
            this.PanelBuscar.Name = "PanelBuscar";
            this.PanelBuscar.Size = new System.Drawing.Size(347, 40);
            this.PanelBuscar.TabIndex = 13;
            // 
            // LbBuscar
            // 
            this.LbBuscar.AutoSize = true;
            this.LbBuscar.Location = new System.Drawing.Point(9, 10);
            this.LbBuscar.Name = "LbBuscar";
            this.LbBuscar.Size = new System.Drawing.Size(70, 20);
            this.LbBuscar.TabIndex = 0;
            this.LbBuscar.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(92, 7);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(192, 26);
            this.TxtBuscar.TabIndex = 14;
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
            // 
            // PbUsuario
            // 
            this.PbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.PbUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbUsuario.BackgroundImage")));
            this.PbUsuario.Location = new System.Drawing.Point(339, 113);
            this.PbUsuario.Name = "PbUsuario";
            this.PbUsuario.Size = new System.Drawing.Size(127, 133);
            this.PbUsuario.TabIndex = 12;
            this.PbUsuario.TabStop = false;
            // 
            // FrmABMUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(525, 399);
            this.ControlBox = false;
            this.Controls.Add(this.GbUsuarios);
            this.Name = "FrmABMUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.GbUsuarios.ResumeLayout(false);
            this.GbUsuarios.PerformLayout();
            this.PanelBuscar.ResumeLayout(false);
            this.PanelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBCodigo;
        private System.Windows.Forms.Label LBNombre;
        private System.Windows.Forms.Label LBContraseña;
        private System.Windows.Forms.Label LBPerfil;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TextContraseña;
        private System.Windows.Forms.ComboBox CBPerfil;
        private System.Windows.Forms.GroupBox GbUsuarios;
        private System.Windows.Forms.Button BtEliminat;
        private System.Windows.Forms.Button BtModificar;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.PictureBox PbUsuario;
        private System.Windows.Forms.Panel PanelBuscar;
        private System.Windows.Forms.Button BtLupa;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LbBuscar;
    }
}