using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    public interface IjogosRepository
    {
        /// <summary>
        /// Método para cadastrar novo jogo
        /// </summary>
        /// <param name="NovoJogo"></param>
        void Cadastrar(JogosDomain NovoJogo);

        /// <summary>
        /// Método de Listar jogos existentes no banco de dados
        /// </summary>
        /// <returns>Lista De Jogos</returns>
        List<JogosDomain> ListarTodos();

        /// <summary>
        /// Método que deleta um jogo passando seu Id.
        /// </summary>
        /// <param name="Id"></param>
        void Deletar (int Id);
    }
}
