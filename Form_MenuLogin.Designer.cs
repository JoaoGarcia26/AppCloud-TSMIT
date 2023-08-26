using AppCloud_TSMIT.Dominio;

namespace AppCloud_TSMIT
{
    partial class Form_MenuLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MenuLogin));
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_Suporte = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_LembrarMe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.btn_Entrar, "btn_Entrar");
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btn_Suporte
            // 
            resources.ApplyResources(this.btn_Suporte, "btn_Suporte");
            this.btn_Suporte.Name = "btn_Suporte";
            this.btn_Suporte.UseVisualStyleBackColor = true;
            this.btn_Suporte.Click += new System.EventHandler(this.btn_Suporte_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::AppCloud_TSMIT.Properties.Resources.logoPequeno;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // txt_User
            // 
            resources.ApplyResources(this.txt_User, "txt_User");
            this.txt_User.Name = "txt_User";
            this.txt_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_User_KeyDown);
            // 
            // txt_Pass
            // 
            resources.ApplyResources(this.txt_Pass, "txt_Pass");
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Pass_KeyDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // box_LembrarMe
            // 
            resources.ApplyResources(this.box_LembrarMe, "box_LembrarMe");
            this.box_LembrarMe.Name = "box_LembrarMe";
            this.box_LembrarMe.UseVisualStyleBackColor = true;
            // 
            // Form_MenuLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.box_LembrarMe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.btn_Suporte);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_MenuLogin";
            this.Load += new System.EventHandler(this.Form_MenuLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_MenuLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button btn_Suporte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox box_LembrarMe;
    }
}