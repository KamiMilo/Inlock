using inlock_codefirst.Domains;

namespace inlock_codefirst.Interfaces
{
    public interface IJogoRepository
    {
        void Cadastrar(Jogo jogo);

        List<Jogo> Listar();

        void BuscarporId(Guid Id);

        void Atualizar(Guid Id, Jogo jogo);

        void Deletar(Guid Id);

    }
}
