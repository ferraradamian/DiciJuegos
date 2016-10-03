namespace CapaPresentacion
{
    partial class JuegoRana
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PtrBxMosca = new System.Windows.Forms.PictureBox();
            this.PtrBxRana = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LbPuntos = new System.Windows.Forms.Label();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtrBxMosca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtrBxRana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // PtrBxMosca
            // 
            this.PtrBxMosca.BackColor = System.Drawing.Color.Transparent;
            this.PtrBxMosca.Image = global::CapaPresentacion.Properties.Resources.Mosca;
            this.PtrBxMosca.Location = new System.Drawing.Point(223, 172);
            this.PtrBxMosca.Name = "PtrBxMosca";
            this.PtrBxMosca.Size = new System.Drawing.Size(55, 55);
            this.PtrBxMosca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtrBxMosca.TabIndex = 2;
            this.PtrBxMosca.TabStop = false;
            // 
            // PtrBxRana
            // 
            this.PtrBxRana.Image = global::CapaPresentacion.Properties.Resources.Rana;
            this.PtrBxRana.InitialImage = null;
            this.PtrBxRana.Location = new System.Drawing.Point(0, 123);
            this.PtrBxRana.Name = "PtrBxRana";
            this.PtrBxRana.Size = new System.Drawing.Size(217, 220);
            this.PtrBxRana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtrBxRana.TabIndex = 1;
            this.PtrBxRana.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LbPuntos
            // 
            this.LbPuntos.AutoSize = true;
            this.LbPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPuntos.Location = new System.Drawing.Point(653, 53);
            this.LbPuntos.Name = "LbPuntos";
            this.LbPuntos.Size = new System.Drawing.Size(92, 25);
            this.LbPuntos.TabIndex = 4;
            this.LbPuntos.Text = "Puntos:";
            // 
            // Pb1
            // 
            this.Pb1.BackColor = System.Drawing.Color.Red;
            this.Pb1.Location = new System.Drawing.Point(0, 189);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(217, 26);
            this.Pb1.TabIndex = 5;
            this.Pb1.TabStop = false;
            // 
            // JuegoRana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.LbPuntos);
            this.Controls.Add(this.PtrBxRana);
            this.Controls.Add(this.Pb1);
            this.Controls.Add(this.PtrBxMosca);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "JuegoRana";
            this.Size = new System.Drawing.Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)(this.PtrBxMosca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtrBxRana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PtrBxRana;
        private System.Windows.Forms.PictureBox PtrBxMosca;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LbPuntos;
        private System.Windows.Forms.PictureBox Pb1;
    }
}
