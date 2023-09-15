using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    public interface IUsuariosRepository
    {
        UsuariosDomain Login(string email, string senha);
    }
}
