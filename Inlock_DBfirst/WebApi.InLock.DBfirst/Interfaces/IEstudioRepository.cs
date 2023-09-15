using WebApi.InLock.DBfirst.Domains;

namespace WebApi.InLock.DBfirst.Interfaces
{
    public interface IEstudioRepository
    {
        List<Estudio> Listar();

        Estudio BuscarPorId(Guid id);

        void cadastrar (Estudio estudio);

        void Atualizar (Guid id,Estudio estudio);

        void Deletar (Guid id);

        List<Estudio> ListarComJogos();
    }
}
