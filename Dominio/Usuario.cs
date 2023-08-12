namespace AppCloud_TSMIT.Dominio
{
    public class Usuario
    {
        public Usuario(string user, string pass) 
        {
            Nome = user;
            Senha = pass;
        }

        public string Nome { get ; set; }
        public string Senha { get; set; }
    }
}
