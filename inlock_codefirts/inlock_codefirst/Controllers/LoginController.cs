using inlock_codefirst.Interfaces;
using inlock_codefirst.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace inlock_codefirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginController()
        {
           _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post()
        {
            

        }
    }
}
