using System;

namespace AppCloud_TSMIT.Dominio
{
    public class Host
    {
        public Host(string url, int portApp, int portController)
        {
            Url = url;
            Port_App = portApp;
            PortController = portController;
        }
        public string Url { get; set; }
        public int Port_App { get; set; }
        public int PortController { get; set; }
    }
}
