using System.IO;
using AppCloud_TSMIT.Dominio;

namespace AppCloud_TSMIT.Controller
{
    internal class HashPassword
    {
        private readonly string path = @"C:\Windows\Temp\26sd258fe3";

        public bool VerifyFilePassExist()
        {
            return File.Exists($@"{path}");
        }
        public void CreateAndWriteFilePass(Usuario user)
        {
            using (StreamWriter writer = File.CreateText(path))
            {
                writer.WriteLine($"{user.Nome}={user.Senha}");
            }
        }
        public string[] ReadPassInFile()
        {
            string[] credenciais = new string[2];
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            credenciais[0] = parts[0].Trim();
                            credenciais[1] = parts[1].Trim();
                        }
                    }
                }
            }
            return credenciais;
        }
    }
}
