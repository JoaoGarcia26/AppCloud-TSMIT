namespace AppCloud_TSMIT
{
    partial class Form_MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MenuPrincipal));
            this.imgAgro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAgro)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAgro
            // 
            this.imgAgro.Image = ((System.Drawing.Image)(resources.GetObject("imgAgro.Image")));
            this.imgAgro.Location = new System.Drawing.Point(403, 141);
            this.imgAgro.Name = "imgAgro";
            this.imgAgro.Size = new System.Drawing.Size(87, 91);
            this.imgAgro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAgro.TabIndex = 0;
            this.imgAgro.TabStop = false;
            this.imgAgro.DoubleClick += new System.EventHandler(this.imgAgro_DoubleClick);
            // 
            // Form_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 402);
            this.Controls.Add(this.imgAgro);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSMIT - Aplicação Cloud";
            this.Load += new System.EventHandler(this.Form_MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAgro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAgro;
    }
}

