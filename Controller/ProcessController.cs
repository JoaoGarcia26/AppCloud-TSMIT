using AppCloud_TSMIT.Dominio;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace AppCloud_TSMIT.Controller
{
    public class ProcessController
    {
        public static void ChamadaDoProcessoAppController(Host host, Usuario usuario, string app)
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
