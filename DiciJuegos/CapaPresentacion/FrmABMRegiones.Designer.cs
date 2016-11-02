namespace CapaPresentacion
{
    partial class FrmABMRegiones
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
            this.GbRegion = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChlbRegiones = new System.Windows.Forms.CheckedListBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.LbRegion = new System.Windows.Forms.Label();
            this.BtSalir = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtModificar = new System.Windows.Forms.Button();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.GbRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GbRegion
            // 
            this.GbRegion.BackColor = System.Drawing.Color.Transparent;
            this.GbRegion.Controls.Add(this.pictureBox1);
            this.GbRegion.Controls.Add(this.ChlbRegiones);
            this.GbRegion.Controls.Add(this.txtRegion);
            this.GbRegion.Controls.Add(this.LbRegion);
            this.GbRegion.Controls.Add(this.BtSalir);
            this.GbRegion.Controls.Add(this.BtEliminar);
            this.GbRegion.Controls.Add(this.BtModificar);
            this.GbRegion.Controls.Add(this.BtAgregar);
            this.GbRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbRegion.ForeColor = System.Drawing.Color.White;
            this.GbRegion.Location = new System.Drawing.Point(7, 7);
            this.GbRegion.Name = "GbRegion";
            this.GbRegion.Size = new System.Drawing.Size(425, 274);
            this.GbRegion.TabIndex = 9;
            this.GbRegion.TabStop = false;
            this.GbRegion.Text = "Regiones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CapaPresentacion.Properties.Resources.zone_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(326, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 55);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // ChlbRegiones
            // 
            this.ChlbRegiones.CheckOnClick = true;
            this.ChlbRegiones.FormattingEnabled = true;
            this.ChlbRegiones.Location = new System.Drawing.Point(17, 80);
            this.ChlbRegiones.Name = "ChlbRegiones";
            this.ChlbRegiones.Size = new System.Drawing.Size(395, 109);
            this.ChlbRegiones.Sorted = true;
            this.ChlbRegiones.TabIndex = 1;
            this.ChlbRegiones.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChlbCategorias_ItemCheck);
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(123, 35);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(191, 26);
            this.txtRegion.TabIndex = 19;
            // 
            // LbRegion
            // 
            this.LbRegion.AutoSize = true;
            this.LbRegion.ForeColor = System.Drawing.Color.Black;
            this.LbRegion.Location = new System.Drawing.Point(25, 37);
            this.LbRegion.Name = "LbRegion";
            this.LbRegion.Size = new System.Drawing.Size(71, 20);
            this.LbRegion.TabIndex = 18;
            this.LbRegion.Text = "Region:";
            this.LbRegion.UseWaitCursor = true;
            // 
            // BtSalir
            // 
            this.BtSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtSalir.ForeColor = System.Drawing.Color.Black;
            this.BtSalir.Location = new System.Drawing.Point(320, 204);
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
            this.BtEliminar.Location = new System.Drawing.Point(222, 204);
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
            this.BtModificar.Location = new System.Drawing.Point(123, 204);
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
            this.BtAgregar.Location = new System.Drawing.Point(17, 204);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(92, 53);
            this.BtAgregar.TabIndex = 8;
            this.BtAgregar.Text = "Agregar";
            this.BtAgregar.UseVisualStyleBackColor = false;
            this.BtAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // FrmABMRegiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.textura_1_celeste;
            this.ClientSize = new System.Drawing.Size(446, 289);
            this.ControlBox = false;
            this.Controls.Add(this.GbRegion);
            this.Name = "FrmABMRegiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regiones";
            this.Load += new System.EventHandler(this.FrmABMRegiones_Load);
            this.GbRegion.ResumeLayout(false);
            this.GbRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbRegion;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button BtModificar;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label LbRegion;
        private System.Windows.Forms.CheckedListBox ChlbRegiones;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}