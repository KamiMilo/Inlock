using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Repositories;

namespace senai.inlock.webApi.Controllers
{
    //Define que a rota de uma requisição será no seguinte formato
    //dominio/api/nomeController
    //ex:http://localhost:5266//api/jogos

    [Route("api/[controller]")]

    [ApiController]

    //Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]
    public class JogosController : ControllerBase
    {
       private JogosRepository  _JogosRepository { get; set; }

        public JogosController()
        {
            _JogosRepository = new JogosRepository();
        }

        /// <summary>
        /// Endpoint que aciona o método listar
        /// </summary>
        /// <returns>Lista de jogos</returns>

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                //instanciado uma lista de jogos para guardar a lista do método
                //chamada do método atráves da  váriavel de acesso _jogosRepository
                List<JogosDomain> ListaDejogos = _JogosRepository.ListarTodos();

                //Retorna lista de jogos.
                return Ok(ListaDejogos);
             }

            catch(Exception erro) { 

                return BadRequest(erro.Message);
            }
        }
        /// <summary>
        /// Endpoint que aciona o método cadastrar
        /// </summary>
        /// <param name="novojogo"></param>
        /// <returns>StatusCode 201</returns>

        [HttpPost]
        [Authorize (Roles ="Administrador")]
        public IActionResult Post(JogosDomain novojogo)
        {
            try
            {
                //apenas chama o método atraves da variavel de acesso.
                _JogosRepository.Cadastrar(novojogo);

                return StatusCode(201);

            }

            catch(Exception erro)
            {
                return BadRequest(erro.Message);
            }

                
        }
        /// <summary>
        /// Endpoint que aciona o método deletar
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Authorize(Roles = "Administrador")]

        public IActionResult Delete(int id)
        {
            try
            {

            _JogosRepository.Deletar(id);

                return StatusCode(204);
            }

            catch(Exception erro) 
            { 
                return BadRequest(erro.Message);
            }

        }
    }
}
