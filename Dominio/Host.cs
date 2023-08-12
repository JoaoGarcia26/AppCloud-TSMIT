using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCloud_TSMIT.Dominio
{
    public class Host
    {
        public Host()
        {
            Url = "192.168.30.42";
            Port = 491;
        }
        public string Url { get; set; }
        public int Port { get; set; }
    }
}
