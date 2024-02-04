using Microsoft.EntityFrameworkCore;
using sql_api.Model;

namespace sql_api.Infraestrutura
{
    public class ConnectionContext: DbContext
    {
      public DbSet <Usuarios> Usuarios {  get; set; }    //inverte quando for plural tipo employeers uso o usuario

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=seu_server;Database=seu_banco;User Id=seu_id;Password=seu_password;TrustServerCertificate=True;");
        }
    }
}
