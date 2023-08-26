using AppCloud_TSMIT.Dominio;
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCloud_TSMIT.Controller
{
    public class ClientConnection
    {
        private bool result;
        public async Task<bool> SocketConnectionAsync(Host host, string credenciais)
        {
            string serverIpAddress = host.Url;
            int serverPort = host.Port_Controller;

            try
            {
                using (TcpClient client = new TcpClient())
                {
                    await client.ConnectAsync(serverIpAddress, serverPort);

                    using (NetworkStream stream = client.GetStream())
                    {
                        byte[] buffer = Encoding.UTF8.GetBytes(credenciais);
                        await stream.WriteAsync(buffer, 0, buffer.Length);

                        byte[] responseBuffer = new byte[1024];
                        int bytesRead = await stream.ReadAsync(responseBuffer, 0, responseBuffer.Length);
                        string response = Encoding.UTF8.GetString(responseBuffer, 0, bytesRead);

                        Console.WriteLine("Server response: " + response);

                        if (response == "True")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Servidor ou controller desligado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
