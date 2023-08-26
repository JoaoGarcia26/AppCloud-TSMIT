using AppCloud_TSMIT.Controller;
using System;
using System.Windows.Forms;

namespace AppCloud_TSMIT
{
    public partial class Form_MenuLogin : Form
    {
        private readonly ConfigController config;
        private readonly LoginController loginController;
        private readonly HashPassword hashPassword;
        
        public Form_MenuLogin()
        {
            InitializeComponent();
            config = new ConfigController();
            hashPassword = new HashPassword();
            loginController = new LoginController(config, this);
        }

        private async void btn_Entrar_Click(object sender, EventArgs e)
        {
            await loginController.RequestAndResultLogin(txt_User.Text, txt_Pass.Text);
        }

        private void btn_Suporte_Click(object sender, EventArgs e)
        {
            string target = "https://tsmit.com.br";
            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void Form_MenuLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                btn_Entrar_Click(sender, e);
            }
        }

        private void txt_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Entrar_Click(sender, e);
            }
        }

        private void txt_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Entrar_Click(sender, e);
            }
        }

        private void Form_MenuLogin_Load(object sender, EventArgs e)
        {
            txt_User.Select();
            if (hashPassword.VerifyFilePassExist() == true)
            {
                box_LembrarMe.Checked = true;
                txt_User.Text = hashPassword.ReadPassInFile()[0];
                txt_Pass.Text = hashPassword.ReadPassInFile()[1];
            }
            else
            {
                box_LembrarMe.Checked= false;
            }
        }
    }
}
