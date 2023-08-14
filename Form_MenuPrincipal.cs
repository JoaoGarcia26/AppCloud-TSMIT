using AppCloud_TSMIT.Dominio;
using System;
using System.Windows.Forms;

namespace AppCloud_TSMIT
{
    public partial class Form_MenuPrincipal : Form
    {

        private readonly Host _host;
        private readonly Usuario _usuario;
        public Form_MenuPrincipal()
        {
            InitializeComponent();
        }
        public Form_MenuPrincipal(Host host, Usuario user)
        {
            InitializeComponent();
            _host = host;
            _usuario = user;
        }

        private void imgAgro_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "C:\\Users\\João Victor\\AppData\\Local\\GraphOn\\AppController\\AppController.exe";
            startInfo.Arguments = $@"-h {_host.Url} -u .\{_usuario.Nome} -p {_usuario.Senha} -a Filezilla";

            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
