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

        public Form_MenuLogin()
        {
            InitializeComponent();

        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_User.Text) && !String.IsNullOrEmpty(txt_Pass.Text))
            {
                Host host = new Host();
                Usuario usuario = new Usuario(txt_User.Text, txt_Pass.Text);

                bool isValid = TesteCredenciais(host.Url, txt_User.Text, txt_Pass.Text);
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

        private bool TesteCredenciais(string hostname, string user, string pass)
        {
            string remoteComputerName = hostname;
            string username = user;
            string password = pass;

            using (PrincipalContext context = new PrincipalContext(ContextType.Machine, remoteComputerName, username, password))
            {
                try
                {
                    bool isAuthenticated = context.ValidateCredentials(username, password);
                    return true;
                } catch (System.IO.FileNotFoundException)
                {
                    return true;
                    
                } catch (System.DirectoryServices.AccountManagement.PrincipalOperationException)
                {
                    return false;
                }
            } 
        }
    }
}
