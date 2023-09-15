using inlock_codefirst.Domains;
using inlock_codefirst.Interfaces;
using inlock_codefirst.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace inlock_codefirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController() 
        { 
            _usuarioRepository= new UsuarioRepository();
        }


        [HttpPost]

        public IActionResult Post(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);

                return Ok();

            }

            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
