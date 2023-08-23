using AppCloud_TSMIT.Dominio;
using System;

namespace AppCloud_TSMIT.Controller
{
    public class ProcessController
    {
        public static void ChamadaDoProcessoAppController(Host host, Usuario usuario, ConfigController config, string app)
        {
            string nameSrv = config.GetNomeServidor();
            int portApp = config.GetPortApp();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            // VALIDA X32 OU X64 DO WINDOWS
            if (Environment.Is64BitOperatingSystem)
            {
                startInfo.FileName = "C:\\Program Files (x86)\\GraphOn\\AppController\\AppController.exe";
            } else
            {
                startInfo.FileName = "C:\\Program Files\\GraphOn\\AppController\\AppController.exe";
            }
            startInfo.Arguments = $@"-h {host.Url} -hp {portApp} -u {nameSrv}\{usuario.Nome} -p {usuario.Senha} -a {app}";
            process.StartInfo = startInfo;
            process.Start();
            Console.WriteLine($"Chamando o processo {app}");
        }
    }
}
