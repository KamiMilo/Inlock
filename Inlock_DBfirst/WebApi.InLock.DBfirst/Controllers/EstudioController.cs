using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.InLock.DBfirst.Domains;
using WebApi.InLock.DBfirst.Interfaces;
using WebApi.InLock.DBfirst.Repositories;

namespace WebApi.InLock.DBfirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository { get; set; }

        public EstudioController()
        {
            _estudioRepository = new EstudioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_estudioRepository.Listar());
            }

            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpGet("ComJogos")]
        public IActionResult GetWithGames()
        {
            try
            {
                return Ok(_estudioRepository.ListarComJogos());
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {

            return Ok(_estudioRepository.BuscarPorId(id));
            }

            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {

             _estudioRepository.Deletar(id);

               return NoContent();

            }

            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Estudio novoEstudio)
        {
            try
            {
                _estudioRepository.cadastrar(novoEstudio);

                return StatusCode(201);
            }

            catch (Exception e)

            { 
                return BadRequest(e.Message);
            }

        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id ,Estudio estudio)
        {
            try
            {
              _estudioRepository.Atualizar(id, estudio);

              return NoContent();

            }

            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }

}
