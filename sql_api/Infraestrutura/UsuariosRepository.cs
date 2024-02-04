using sql_api.Model;

namespace sql_api.Infraestrutura
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly ConnectionContext _contexto = new ConnectionContext(); // chamando minha conexão com o banco

        public void Add(Usuarios usuarios)
        {
            _contexto.Usuarios.Add(usuarios);
            _contexto.SaveChanges();  // salvando a alteração

        }

        public List<Usuarios> GetUsuarios()
        {
            return _contexto.Usuarios.ToList();
        }
    }
}
