namespace CapaPresentacion
{
    partial class FrmConfiguracion
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
            this.GbConfiguracion = new System.Windows.Forms.GroupBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.CmbxRegion = new System.Windows.Forms.ComboBox();
            this.LRegion = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GbConfiguracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbConfiguracion
            // 
            this.GbConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GbConfiguracion.Controls.Add(this.BtnAceptar);
            this.GbConfiguracion.Controls.Add(this.CmbxRegion);
            this.GbConfiguracion.Controls.Add(this.LRegion);
            this.GbConfiguracion.Controls.Add(this.BtnCancelar);
            this.GbConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbConfiguracion.ForeColor = System.Drawing.Color.Black;
            this.GbConfiguracion.Location = new System.Drawing.Point(12, 12);
            this.GbConfiguracion.Name = "GbConfiguracion";
            this.GbConfiguracion.Size = new System.Drawing.Size(324, 173);
            this.GbConfiguracion.TabIndex = 10;
            this.GbConfiguracion.TabStop = false;
            this.GbConfiguracion.Text = "Configuracion";
            this.GbConfiguracion.Enter += new System.EventHandler(this.GbConfiguracion_Enter);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAceptar.ForeColor = System.Drawing.Color.Black;
            this.BtnAceptar.Location = new System.Drawing.Point(29, 104);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(92, 53);
            this.BtnAceptar.TabIndex = 20;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // CmbxRegion
            // 
            this.CmbxRegion.FormattingEnabled = true;
            this.CmbxRegion.Items.AddRange(new object[] {
            "Los Hornos",
            "La plata",
            "Escuela 46"});
            this.CmbxRegion.Location = new System.Drawing.Point(103, 39);
            this.CmbxRegion.Name = "CmbxRegion";
            this.CmbxRegion.Size = new System.Drawing.Size(190, 28);
            this.CmbxRegion.TabIndex = 19;
            // 
            // LRegion
            // 
            this.LRegion.AutoSize = true;
            this.LRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LRegion.ForeColor = System.Drawing.Color.Black;
            this.LRegion.Location = new System.Drawing.Point(25, 41);
            this.LRegion.Name = "LRegion";
            this.LRegion.Size = new System.Drawing.Size(71, 20);
            this.LRegion.TabIndex = 18;
            this.LRegion.Text = "Region:";
            this.LRegion.UseWaitCursor = true;
            this.LRegion.Click += new System.EventHandler(this.LRegion_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.Location = new System.Drawing.Point(201, 104);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(92, 53);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(342, 193);
            this.Controls.Add(this.GbConfiguracion);
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.GbConfiguracion.ResumeLayout(false);
            this.GbConfiguracion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbConfiguracion;
        private System.Windows.Forms.Label LRegion;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.ComboBox CmbxRegion;
    }
}