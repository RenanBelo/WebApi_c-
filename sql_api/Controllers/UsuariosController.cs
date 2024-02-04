using Microsoft.AspNetCore.Mvc;
using sql_api.Model;
using sql_api.ViewModel;

namespace sql_api.Controllers
{

    [ApiController]
    [Route("api/v1/usuarios")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuariosRepository _usuariosRepository;

        public UsuariosController(IUsuariosRepository usuariosRepository)
        {
            _usuariosRepository = usuariosRepository ?? throw new ArgumentNullException(nameof(usuariosRepository));    
        }

        [HttpPost] // é pra adicionar, utilizamos o verbo POST
        public IActionResult Add( UsuariosViewModel usuarioview)
            /* 
              eu importei a classe toda pra não precisar pegar todos os atributos dela tipo assim: 
             "public IActionResult Add( string nome, string email,  int idade)"

            */
        {
             var usuario = new Usuarios(usuarioview.Nome, usuarioview.Email, usuarioview.Idade);

            _usuariosRepository.Add(usuario);

            return Ok();

        }

        [HttpGet]
        public IActionResult Get()
        {
            var usuario = _usuariosRepository.GetUsuarios();

            return Ok(usuario);
        }


    }
}
