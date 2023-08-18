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
            this.painel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // painel
            // 
            this.painel.Location = new System.Drawing.Point(133, 137);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(627, 115);
            this.painel.TabIndex = 6;
            // 
            // Form_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 402);
            this.Controls.Add(this.painel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSMIT - Aplicação Cloud";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.Form_MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel painel;
    }
}

