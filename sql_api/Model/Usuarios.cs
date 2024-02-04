namespace sql_api.Model
{
    public class Usuarios
    {
        public Usuarios(string nome, string email, int idade)
        {
            
            Nome = nome;
            Email = email;
            Idade = idade;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
    }
}
