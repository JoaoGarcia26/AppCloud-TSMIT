using AppCloud_TSMIT.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Form_MenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void imgAgro_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "C:\\Users\\João Victor\\AppData\\Local\\GraphOn\\AppController\\AppController.exe";
            startInfo.Arguments = $@"-h {_host.Url} -u .\{_usuario.Nome} -p {_usuario.Senha} -a Notepad";

            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
