using System.Windows.Forms;

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
            this.neoImg = new System.Windows.Forms.PictureBox();
            this.agroImg = new System.Windows.Forms.PictureBox();
            this.pastaDesktopImg = new System.Windows.Forms.PictureBox();
            this.touchImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.neoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agroImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pastaDesktopImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.touchImg)).BeginInit();
            this.SuspendLayout();
            // 
            // painel
            // 
            this.painel.Location = new System.Drawing.Point(140, 133);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(614, 122);
            this.painel.TabIndex = 0;
            // 
            // neoImg
            // 
            this.neoImg.Location = new System.Drawing.Point(140, 12);
            this.neoImg.Name = "neoImg";
            this.neoImg.Size = new System.Drawing.Size(100, 50);
            this.neoImg.TabIndex = 2;
            this.neoImg.TabStop = false;
            this.neoImg.DoubleClick += new System.EventHandler(this.Image_DoubleClick);
            // 
            // agroImg
            // 
            this.agroImg.Location = new System.Drawing.Point(12, 12);
            this.agroImg.Name = "agroImg";
            this.agroImg.Size = new System.Drawing.Size(100, 50);
            this.agroImg.TabIndex = 1;
            this.agroImg.TabStop = false;
            this.agroImg.DoubleClick += new System.EventHandler(this.Image_DoubleClick);
            // 
            // pastaDesktopImg
            // 
            this.pastaDesktopImg.Location = new System.Drawing.Point(446, 12);
            this.pastaDesktopImg.Name = "pastaDesktopImg";
            this.pastaDesktopImg.Size = new System.Drawing.Size(100, 50);
            this.pastaDesktopImg.TabIndex = 4;
            this.pastaDesktopImg.TabStop = false;
            this.pastaDesktopImg.DoubleClick += new System.EventHandler(this.Image_DoubleClick);
            // 
            // touchImg
            // 
            this.touchImg.Location = new System.Drawing.Point(286, 12);
            this.touchImg.Name = "touchImg";
            this.touchImg.Size = new System.Drawing.Size(100, 50);
            this.touchImg.TabIndex = 3;
            this.touchImg.TabStop = false;
            this.touchImg.DoubleClick += new System.EventHandler(this.Image_DoubleClick);
            // 
            // Form_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AppCloud_TSMIT.Properties.Resources.wallpaperBrancoBMP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 402);
            this.Controls.Add(this.pastaDesktopImg);
            this.Controls.Add(this.touchImg);
            this.Controls.Add(this.neoImg);
            this.Controls.Add(this.agroImg);
            this.Controls.Add(this.painel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSMIT - Aplicação Cloud";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.Form_MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.neoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agroImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pastaDesktopImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.touchImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public PictureBox agroImg;
        public PictureBox neoImg;
        public PictureBox touchImg;
        public PictureBox pastaDesktopImg;
        public Panel painel;
    }
}

