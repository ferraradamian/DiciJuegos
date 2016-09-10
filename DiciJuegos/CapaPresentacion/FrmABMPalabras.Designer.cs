namespace CapaPresentacion
{
    partial class FrmABMPalabras
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
            this.GbPalabra = new System.Windows.Forms.GroupBox();
            this.ChlbRegiones = new System.Windows.Forms.CheckedListBox();
            this.BtSalir = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtModificar = new System.Windows.Forms.Button();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.LbRegion = new System.Windows.Forms.Label();
            this.LbCategoria = new System.Windows.Forms.Label();
            this.ChlbCategorias = new System.Windows.Forms.CheckedListBox();
            this.LblPalabra = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblImagen = new System.Windows.Forms.Label();
            this.lblSeña = new System.Windows.Forms.Label();
            this.LblModulacion = new System.Windows.Forms.Label();
            this.TxtPalabra = new System.Windows.Forms.TextBox();
            this.Txtdescripcion = new System.Windows.Forms.TextBox();
            this.TxtImagen = new System.Windows.Forms.TextBox();
            this.TxtSeña = new System.Windows.Forms.TextBox();
            this.TxtModulacion = new System.Windows.Forms.TextBox();
            this.PctbxPalabra = new System.Windows.Forms.PictureBox();
            this.GbPalabra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctbxPalabra)).BeginInit();
            this.SuspendLayout();
            // 
            // GbPalabra
            // 
            this.GbPalabra.Controls.Add(this.PctbxPalabra);
            this.GbPalabra.Controls.Add(this.TxtModulacion);
            this.GbPalabra.Controls.Add(this.TxtSeña);
            this.GbPalabra.Controls.Add(this.TxtImagen);
            this.GbPalabra.Controls.Add(this.Txtdescripcion);
            this.GbPalabra.Controls.Add(this.TxtPalabra);
            this.GbPalabra.Controls.Add(this.LblModulacion);
            this.GbPalabra.Controls.Add(this.lblSeña);
            this.GbPalabra.Controls.Add(this.LblImagen);
            this.GbPalabra.Controls.Add(this.LblDescripcion);
            this.GbPalabra.Controls.Add(this.LblPalabra);
            this.GbPalabra.Controls.Add(this.ChlbCategorias);
            this.GbPalabra.Controls.Add(this.LbCategoria);
            this.GbPalabra.Controls.Add(this.ChlbRegiones);
            this.GbPalabra.Controls.Add(this.LbRegion);
            this.GbPalabra.Controls.Add(this.BtSalir);
            this.GbPalabra.Controls.Add(this.BtEliminar);
            this.GbPalabra.Controls.Add(this.BtModificar);
            this.GbPalabra.Controls.Add(this.BtAgregar);
            this.GbPalabra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbPalabra.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GbPalabra.Location = new System.Drawing.Point(0, 0);
            this.GbPalabra.Name = "GbPalabra";
            this.GbPalabra.Size = new System.Drawing.Size(534, 477);
            this.GbPalabra.TabIndex = 10;
            this.GbPalabra.TabStop = false;
            this.GbPalabra.Text = "Palabras";
            // 
            // ChlbRegiones
            // 
            this.ChlbRegiones.CheckOnClick = true;
            this.ChlbRegiones.FormattingEnabled = true;
            this.ChlbRegiones.Items.AddRange(new object[] {
            "Los Hornos"});
            this.ChlbRegiones.Location = new System.Drawing.Point(11, 290);
            this.ChlbRegiones.Name = "ChlbRegiones";
            this.ChlbRegiones.Size = new System.Drawing.Size(210, 109);
            this.ChlbRegiones.Sorted = true;
            this.ChlbRegiones.TabIndex = 1;
            // 
            // BtSalir
            // 
            this.BtSalir.Location = new System.Drawing.Point(403, 416);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(92, 53);
            this.BtSalir.TabIndex = 11;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = false;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Location = new System.Drawing.Point(282, 418);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(92, 53);
            this.BtEliminar.TabIndex = 10;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = false;
            // 
            // BtModificar
            // 
            this.BtModificar.Location = new System.Drawing.Point(160, 416);
            this.BtModificar.Name = "BtModificar";
            this.BtModificar.Size = new System.Drawing.Size(92, 53);
            this.BtModificar.TabIndex = 9;
            this.BtModificar.Text = "Modificar";
            this.BtModificar.UseVisualStyleBackColor = false;
            // 
            // BtAgregar
            // 
            this.BtAgregar.Location = new System.Drawing.Point(42, 416);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(92, 53);
            this.BtAgregar.TabIndex = 8;
            this.BtAgregar.Text = "Agregar";
            this.BtAgregar.UseVisualStyleBackColor = false;
            // 
            // LbRegion
            // 
            this.LbRegion.AutoSize = true;
            this.LbRegion.Location = new System.Drawing.Point(9, 267);
            this.LbRegion.Name = "LbRegion";
            this.LbRegion.Size = new System.Drawing.Size(71, 20);
            this.LbRegion.TabIndex = 18;
            this.LbRegion.Text = "Region:";
            this.LbRegion.UseWaitCursor = true;
            // 
            // LbCategoria
            // 
            this.LbCategoria.AutoSize = true;
            this.LbCategoria.Location = new System.Drawing.Point(284, 267);
            this.LbCategoria.Name = "LbCategoria";
            this.LbCategoria.Size = new System.Drawing.Size(92, 20);
            this.LbCategoria.TabIndex = 19;
            this.LbCategoria.Text = "Categoria:";
            this.LbCategoria.UseWaitCursor = true;
            // 
            // ChlbCategorias
            // 
            this.ChlbCategorias.CheckOnClick = true;
            this.ChlbCategorias.FormattingEnabled = true;
            this.ChlbCategorias.Items.AddRange(new object[] {
            "Animales"});
            this.ChlbCategorias.Location = new System.Drawing.Point(288, 290);
            this.ChlbCategorias.Name = "ChlbCategorias";
            this.ChlbCategorias.Size = new System.Drawing.Size(228, 109);
            this.ChlbCategorias.Sorted = true;
            this.ChlbCategorias.TabIndex = 20;
            // 
            // LblPalabra
            // 
            this.LblPalabra.AutoSize = true;
            this.LblPalabra.Location = new System.Drawing.Point(12, 35);
            this.LblPalabra.Name = "LblPalabra";
            this.LblPalabra.Size = new System.Drawing.Size(75, 20);
            this.LblPalabra.TabIndex = 21;
            this.LblPalabra.Text = "Palabra:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(11, 73);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(108, 20);
            this.LblDescripcion.TabIndex = 22;
            this.LblDescripcion.Text = "Descripcion:";
            // 
            // LblImagen
            // 
            this.LblImagen.AutoSize = true;
            this.LblImagen.Location = new System.Drawing.Point(7, 151);
            this.LblImagen.Name = "LblImagen";
            this.LblImagen.Size = new System.Drawing.Size(74, 20);
            this.LblImagen.TabIndex = 23;
            this.LblImagen.Text = "Imagen:";
            // 
            // lblSeña
            // 
            this.lblSeña.AutoSize = true;
            this.lblSeña.Location = new System.Drawing.Point(12, 189);
            this.lblSeña.Name = "lblSeña";
            this.lblSeña.Size = new System.Drawing.Size(56, 20);
            this.lblSeña.TabIndex = 24;
            this.lblSeña.Text = "Seña:";
            // 
            // LblModulacion
            // 
            this.LblModulacion.AutoSize = true;
            this.LblModulacion.Location = new System.Drawing.Point(12, 229);
            this.LblModulacion.Name = "LblModulacion";
            this.LblModulacion.Size = new System.Drawing.Size(105, 20);
            this.LblModulacion.TabIndex = 25;
            this.LblModulacion.Text = "Modulacion:";
            // 
            // TxtPalabra
            // 
            this.TxtPalabra.Location = new System.Drawing.Point(123, 35);
            this.TxtPalabra.Name = "TxtPalabra";
            this.TxtPalabra.Size = new System.Drawing.Size(233, 26);
            this.TxtPalabra.TabIndex = 26;
            // 
            // Txtdescripcion
            // 
            this.Txtdescripcion.Location = new System.Drawing.Point(123, 73);
            this.Txtdescripcion.Multiline = true;
            this.Txtdescripcion.Name = "Txtdescripcion";
            this.Txtdescripcion.Size = new System.Drawing.Size(233, 67);
            this.Txtdescripcion.TabIndex = 27;
            // 
            // TxtImagen
            // 
            this.TxtImagen.Location = new System.Drawing.Point(123, 151);
            this.TxtImagen.Name = "TxtImagen";
            this.TxtImagen.Size = new System.Drawing.Size(233, 26);
            this.TxtImagen.TabIndex = 28;
            // 
            // TxtSeña
            // 
            this.TxtSeña.Location = new System.Drawing.Point(123, 189);
            this.TxtSeña.Name = "TxtSeña";
            this.TxtSeña.Size = new System.Drawing.Size(233, 26);
            this.TxtSeña.TabIndex = 29;
            // 
            // TxtModulacion
            // 
            this.TxtModulacion.Location = new System.Drawing.Point(123, 229);
            this.TxtModulacion.Name = "TxtModulacion";
            this.TxtModulacion.Size = new System.Drawing.Size(233, 26);
            this.TxtModulacion.TabIndex = 30;
            // 
            // PctbxPalabra
            // 
            this.PctbxPalabra.Image = global::CapaPresentacion.Properties.Resources.Word;
            this.PctbxPalabra.Location = new System.Drawing.Point(380, 35);
            this.PctbxPalabra.Name = "PctbxPalabra";
            this.PctbxPalabra.Size = new System.Drawing.Size(136, 155);
            this.PctbxPalabra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctbxPalabra.TabIndex = 31;
            this.PctbxPalabra.TabStop = false;
            // 
            // FrmABMPalabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(534, 477);
            this.ControlBox = false;
            this.Controls.Add(this.GbPalabra);
            this.Name = "FrmABMPalabras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palabras";
            this.GbPalabra.ResumeLayout(false);
            this.GbPalabra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctbxPalabra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbPalabra;
        private System.Windows.Forms.CheckedListBox ChlbRegiones;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button BtModificar;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.Label LbCategoria;
        private System.Windows.Forms.Label LbRegion;
        private System.Windows.Forms.TextBox TxtImagen;
        private System.Windows.Forms.TextBox Txtdescripcion;
        private System.Windows.Forms.TextBox TxtPalabra;
        private System.Windows.Forms.Label LblModulacion;
        private System.Windows.Forms.Label lblSeña;
        private System.Windows.Forms.Label LblImagen;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblPalabra;
        private System.Windows.Forms.CheckedListBox ChlbCategorias;
        private System.Windows.Forms.TextBox TxtModulacion;
        private System.Windows.Forms.TextBox TxtSeña;
        private System.Windows.Forms.PictureBox PctbxPalabra;
    }
}