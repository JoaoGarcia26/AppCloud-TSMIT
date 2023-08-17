using AppCloud_TSMIT.Dominio;
using System;
using System.Windows.Forms;

namespace AppCloud_TSMIT
{
    public partial class Form_MenuPrincipal : Form
    {

        private readonly Host host;
        private readonly Usuario usuario;
        private readonly Form_MenuLogin formLogin;
        public Form_MenuPrincipal()
        {
            InitializeComponent();
        }
        public Form_MenuPrincipal(Host host, Usuario user, Form_MenuLogin formLogin)
        {
            InitializeComponent();
            this.host = host;
            this.usuario = user;
            this.formLogin = formLogin;
        }
        private void Form_MenuPrincipal_Load(object sender, EventArgs e)
        {
            formLogin.Visible = false;
        }

        private void Form_MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void appAgro_DoubleClick(object sender, EventArgs e)
        {
            ChamadaDoProcessoApp("Agro");
        }
        private void appAgroLado_DoubleClick(object sender, EventArgs e)
        {
            ChamadaDoProcessoApp("Agro");
        }
        private void appNeo_DoubleClick(object sender, EventArgs e)
        {
            ChamadaDoProcessoApp("Neo");
        }
        private void appNeoLado_DoubleClick(object sender, EventArgs e)
        {
            ChamadaDoProcessoApp("Neo");
        }
        private void appTouchComp_DoubleClick(object sender, EventArgs e)
        {
            ChamadaDoProcessoApp("TouchComp");
        }
        private void appPastaDesktop_DoubleClick(object sender, EventArgs e)
        {
            ChamadaDoProcessoApp($"Desktop");
        }
        public void ChamadaDoProcessoApp(string app)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "C:\\Program Files (x86)\\GraphOn\\AppController\\AppController.exe";
            startInfo.Arguments = $@"-h {host.Url} -u localhost\{usuario.Nome} -p {usuario.Senha} -a {app}";

            process.StartInfo = startInfo;
            process.Start();
            Console.WriteLine($"Chamando o processo {app}");
        }
    }
}
