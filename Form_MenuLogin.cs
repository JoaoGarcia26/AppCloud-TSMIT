using AppCloud_TSMIT.Dominio;
using System;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;

namespace AppCloud_TSMIT
{
    public partial class Form_MenuLogin : Form
    {
        public Host host;
        public Usuario usuario;
        public ClientConnection connection;

        public Form_MenuLogin()
        {
            InitializeComponent();
            connection = new ClientConnection();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_User.Text) && !string.IsNullOrEmpty(txt_Pass.Text))
            {
                Host host = new Host();
                Usuario usuario = new Usuario(txt_User.Text, txt_Pass.Text);

                string credenciais = $"{txt_User.Text}:{txt_Pass.Text}";

                bool isValid = connection.SocketConnection(host, credenciais);
                if (isValid == true)
                {
                    Form_MenuPrincipal form_MenuPrincipal = new Form_MenuPrincipal(host, usuario);
                    form_MenuPrincipal.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos", "Falha na autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campos usuário e senha são obrigatórios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
