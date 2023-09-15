using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    public interface IEstudiosRepository
    {

        void Cadastrar(EstudiosDomain novoEstudio);

        List<EstudiosDomain> ListarTodos();
        

    }
}
