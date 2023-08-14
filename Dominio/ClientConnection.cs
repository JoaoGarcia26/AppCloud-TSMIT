using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace AppCloud_TSMIT.Dominio
{
    public class ClientConnection
    {
        private bool result;
        public bool SocketConnection(Host host, string credenciais)
        {
            string serverIpAddress = host.Url;
            int serverPort = 24442;

            try { 

                TcpClient client = new TcpClient();
                client.Connect(serverIpAddress, serverPort);

                NetworkStream stream = client.GetStream();

                byte[] buffer = Encoding.UTF8.GetBytes(credenciais);

                stream.Write(buffer, 0, buffer.Length);

                byte[] responseBuffer = new byte[1024];
                int bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);
                string response = Encoding.UTF8.GetString(responseBuffer, 0, bytesRead);

                Console.WriteLine("Server response: " + response);

                stream.Close();
                client.Close();

                if (response == "true")
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            } catch {
                MessageBox.Show("Servidor/Controller desligado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }
    }
}
