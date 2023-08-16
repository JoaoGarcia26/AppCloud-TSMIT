using System;
using System.Collections.Generic;
using System.IO;

namespace AppCloud_TSMIT.Controller
{
    public class ConfigController
    {
        public ConfigController() 
        {
            ReadConfigFile();
        }
        private Dictionary<string, string> settings = new Dictionary<string, string>();
        public Dictionary<string, string> ReadConfigFile()
        {
            string configFile = "config.txt";
            CriarArquivoDeConfiguracao(configFile); // Cria o arquivo de configuração se não existir

            try
            {
                using (StreamReader reader = new StreamReader(configFile))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] parts = line.Split('=');
                            if (parts.Length == 2)
                            {
                                string key = parts[0].Trim();
                                string value = parts[1].Trim();
                                settings[key] = value;
                            }
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Erro ao ler o arquivo de config: " + ex.Message);
            }

            return settings;
        }

        public string GetIpServer()
        {
            string ip = null;
            if (settings.TryGetValue("Ip_Servidor", out string serverAddress))
            {
                ip = serverAddress;
            }
            return ip;
        }

        public int GetPortApp()
        {
            int port = new int();
            if (settings.TryGetValue("Porta_Aplicacao", out string portApp))
            {
                port = int.Parse(portApp);
            }
            return port;
        }

        public int GetPortController()
        {
            int port = new int();
            if (settings.TryGetValue("Porta_Controller", out string portController))
            {
                port = int.Parse(portController);
            }
            return port;
        }

        private void CriarArquivoDeConfiguracao(string configFile)
        {
            if (!File.Exists(configFile))
            {
                using (StreamWriter writer = File.CreateText(configFile))
                {
                    writer.WriteLine("#AVISO: Editar somente o conteudo das variaveis!");
                    writer.WriteLine("Ip_Servidor=179.189.84.196");
                    writer.WriteLine("Porta_Aplicacao=491");
                    writer.WriteLine("Porta_Controller=24442");
                }
                Console.WriteLine("Arquivo de configuração criado: " + configFile);
            }
        }
    }
}
