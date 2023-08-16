using AppCloud_TSMIT.Dominio;
using System.Windows.Forms;

namespace AppCloud_TSMIT.Controller
{
    public class LoginController
    {
        private readonly ClientConnection connection;
        private readonly Host host;
        private Usuario usuario;
        public LoginController(ConfigController config) 
        { 
            connection = new ClientConnection();
            host = new Host(config.GetIpServer(), config.GetPortApp(), config.GetPortController());
        }
        public void RequestAndResultLogin(string txt_User, string txt_Pass)
        {
            if (!string.IsNullOrEmpty(txt_User) && !string.IsNullOrEmpty(txt_Pass))
            {
                usuario = new Usuario(txt_User, txt_Pass);

                string credenciais = $"{txt_User}:{txt_Pass}";

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
