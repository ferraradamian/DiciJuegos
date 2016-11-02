namespace CapaPresentacion
{
    partial class FrmABMCategorias
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
            this.GbCategoria = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChlbCategorias = new System.Windows.Forms.CheckedListBox();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.LbCategoria = new System.Windows.Forms.Label();
            this.BtSalir = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtModificar = new System.Windows.Forms.Button();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.GbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GbCategoria
            // 
            this.GbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.GbCategoria.Controls.Add(this.pictureBox1);
            this.GbCategoria.Controls.Add(this.ChlbCategorias);
            this.GbCategoria.Controls.Add(this.TxtCategoria);
            this.GbCategoria.Controls.Add(this.LbCategoria);
            this.GbCategoria.Controls.Add(this.BtSalir);
            this.GbCategoria.Controls.Add(this.BtEliminar);
            this.GbCategoria.Controls.Add(this.BtModificar);
            this.GbCategoria.Controls.Add(this.BtAgregar);
            this.GbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCategoria.ForeColor = System.Drawing.Color.White;
            this.GbCategoria.Location = new System.Drawing.Point(7, 7);
            this.GbCategoria.Name = "GbCategoria";
            this.GbCategoria.Size = new System.Drawing.Size(425, 274);
            this.GbCategoria.TabIndex = 9;
            this.GbCategoria.TabStop = false;
            this.GbCategoria.Text = "Categorias";
            this.GbCategoria.Enter += new System.EventHandler(this.GbCategoria_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CapaPresentacion.Properties.Resources.category_item_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(326, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 55);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // ChlbCategorias
            // 
            this.ChlbCategorias.CheckOnClick = true;
            this.ChlbCategorias.FormattingEnabled = true;
            this.ChlbCategorias.Location = new System.Drawing.Point(17, 80);
            this.ChlbCategorias.Name = "ChlbCategorias";
            this.ChlbCategorias.Size = new System.Drawing.Size(395, 109);
            this.ChlbCategorias.Sorted = true;
            this.ChlbCategorias.TabIndex = 1;
            this.ChlbCategorias.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChlbCategorias_ItemCheck);
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(123, 35);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(191, 26);
            this.TxtCategoria.TabIndex = 19;
            // 
            // LbCategoria
            // 
            this.LbCategoria.AutoSize = true;
            this.LbCategoria.ForeColor = System.Drawing.Color.Black;
            this.LbCategoria.Location = new System.Drawing.Point(25, 37);
            this.LbCategoria.Name = "LbCategoria";
            this.LbCategoria.Size = new System.Drawing.Size(92, 20);
            this.LbCategoria.TabIndex = 18;
            this.LbCategoria.Text = "Categoria:";
            this.LbCategoria.UseWaitCursor = true;
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
            // FrmABMCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.textura_1_celeste;
            this.ClientSize = new System.Drawing.Size(446, 289);
            this.ControlBox = false;
            this.Controls.Add(this.GbCategoria);
            this.Name = "FrmABMCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.GbCategoria.ResumeLayout(false);
            this.GbCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbCategoria;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button BtModificar;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.Label LbCategoria;
        private System.Windows.Forms.CheckedListBox ChlbCategorias;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}