using AppCloud_TSMIT.Dominio;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCloud_TSMIT.Controller
{
    public class LoginController
    {
        private readonly ClientConnection connection;
        private readonly ApplicationController appController;
        private readonly ConfigController configController;
        private readonly HashPassword hashPassword;
        private readonly Form_MenuLogin form_MenuLogin;

        private readonly Host host;
        private Usuario usuario;
        public LoginController(ConfigController config, Form_MenuLogin formLogin) 
        { 
            configController = config;
            form_MenuLogin = formLogin;
            connection = new ClientConnection();
            appController = new ApplicationController(configController);
            hashPassword = new HashPassword();
            host = new Host(config.GetIpServer(), config.GetPortApp(), config.GetPortController());
        }
        public async Task RequestAndResultLogin(string txt_User, string txt_Pass)
        {
            if (!string.IsNullOrEmpty(txt_User) && !string.IsNullOrEmpty(txt_Pass))
            {
                usuario = new Usuario(txt_User, txt_Pass);

                string credenciais = $"{txt_User}:{txt_Pass}";

                bool isValid = await connection.SocketConnectionAsync(host, credenciais);
                if (isValid == true)
                {
                    Form_MenuPrincipal form_MenuPrincipal = new Form_MenuPrincipal(host, usuario, form_MenuLogin, configController);
                    appController.VerificaAplicacoes(form_MenuPrincipal);
                    if (form_MenuLogin.box_LembrarMe.CheckState == CheckState.Checked && hashPassword.VerifyFilePassExist() == false)
                    {
                        hashPassword.CreateAndWriteFilePass(usuario);
                    }
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
