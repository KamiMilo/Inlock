using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace senai.inlock.webApi.Controllers
{
    //ex:http://localhost:5266//api/jogos

    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EstudiosController : ControllerBase
    {

        private EstudiosRepository _EstudiosRepository { get; set; }

        public EstudiosController()
        {
            _EstudiosRepository = new EstudiosRepository();
        }
        /// <summary>
        /// Endpoint que aciona o método de Listar
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                //instanciado uma lista de estudios para guardar a lista do método
                //chamada do método atráves da  váriavel de acesso _EstudiosRepository
                List<EstudiosDomain> ListarEstudios = _EstudiosRepository.ListarTodos();

                //Retorna lista de jogos.
                return Ok(ListarEstudios);
            }

            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }
        /// <summary>
        /// Endpoint que aciona o método cadastrar
        /// </summary>
        /// <param name="novojogo"></param>
        /// <returns>StatusCode 201</returns>

        [HttpPost]
        [Authorize(Roles = "Administrador")]
        public IActionResult Post(EstudiosDomain novoEstudio)
        {
            try
            {
                _EstudiosRepository.Cadastrar(novoEstudio);

                return StatusCode(201);

            }

            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }

        }
        /// <summary>
        /// End point que aciona o método de deletar
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete]
        [Authorize(Roles = "Administrador")]

        public IActionResult Delete(int id)
        {
            try
            {
                _EstudiosRepository.Deletar(id);

                return StatusCode(204);
            }

            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }


    }
}
