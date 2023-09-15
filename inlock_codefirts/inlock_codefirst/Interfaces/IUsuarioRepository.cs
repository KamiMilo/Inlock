using inlock_codefirst.Contexts;
using inlock_codefirst.Domains;

namespace inlock_codefirst.Interfaces
{

    public interface IUsuarioRepository
    {
        Usuario BuscarUsario(string Email, String Senha);

        void Cadastrar(Usuario usuario);
    }
}
