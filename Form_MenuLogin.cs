using AppCloud_TSMIT.Controller;
using AppCloud_TSMIT.Dominio;
using System;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;

namespace AppCloud_TSMIT
{
    public partial class Form_MenuLogin : Form
    {
        private readonly ConfigController config;
        private readonly LoginController loginController;

        public Form_MenuLogin()
        {
            InitializeComponent();
            config = new ConfigController();
            loginController = new LoginController(config);
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            loginController.RequestAndResultLogin(txt_User.Text, txt_Pass.Text);
        }
    }
}
