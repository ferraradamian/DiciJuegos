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
            this.BtSalir = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtModificar = new System.Windows.Forms.Button();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.LbCategoria = new System.Windows.Forms.Label();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.ChlbCategorias = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GbCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbCategoria
            // 
            this.GbCategoria.Controls.Add(this.ChlbCategorias);
            this.GbCategoria.Controls.Add(this.TxtCategoria);
            this.GbCategoria.Controls.Add(this.LbCategoria);
            this.GbCategoria.Controls.Add(this.BtSalir);
            this.GbCategoria.Controls.Add(this.BtEliminar);
            this.GbCategoria.Controls.Add(this.BtModificar);
            this.GbCategoria.Controls.Add(this.BtAgregar);
            this.GbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCategoria.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GbCategoria.Location = new System.Drawing.Point(7, 7);
            this.GbCategoria.Name = "GbCategoria";
            this.GbCategoria.Size = new System.Drawing.Size(425, 274);
            this.GbCategoria.TabIndex = 9;
            this.GbCategoria.TabStop = false;
            this.GbCategoria.Text = "Categorias";
            // 
            // BtSalir
            // 
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
            this.BtEliminar.Location = new System.Drawing.Point(222, 204);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(92, 53);
            this.BtEliminar.TabIndex = 10;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = false;
            // 
            // BtModificar
            // 
            this.BtModificar.Location = new System.Drawing.Point(123, 204);
            this.BtModificar.Name = "BtModificar";
            this.BtModificar.Size = new System.Drawing.Size(92, 53);
            this.BtModificar.TabIndex = 9;
            this.BtModificar.Text = "Modificar";
            this.BtModificar.UseVisualStyleBackColor = false;
            // 
            // BtAgregar
            // 
            this.BtAgregar.Location = new System.Drawing.Point(17, 204);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(92, 53);
            this.BtAgregar.TabIndex = 8;
            this.BtAgregar.Text = "Agregar";
            this.BtAgregar.UseVisualStyleBackColor = false;
            this.BtAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // LbCategoria
            // 
            this.LbCategoria.AutoSize = true;
            this.LbCategoria.Location = new System.Drawing.Point(25, 41);
            this.LbCategoria.Name = "LbCategoria";
            this.LbCategoria.Size = new System.Drawing.Size(92, 20);
            this.LbCategoria.TabIndex = 18;
            this.LbCategoria.Text = "Categoria:";
            this.LbCategoria.UseWaitCursor = true;
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(123, 35);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(140, 26);
            this.TxtCategoria.TabIndex = 19;
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
            // FrmABMCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(446, 289);
            this.ControlBox = false;
            this.Controls.Add(this.GbCategoria);
            this.Name = "FrmABMCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.GbCategoria.ResumeLayout(false);
            this.GbCategoria.PerformLayout();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}