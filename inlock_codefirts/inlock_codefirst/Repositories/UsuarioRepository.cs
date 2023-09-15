using inlock_codefirst.Contexts;
using inlock_codefirst.Domains;
using inlock_codefirst.Interfaces;
using inlock_codefirst.Utils;

namespace inlock_codefirst.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        /// <summary>
        /// Variável privada e somente leitura para armazenar os dados do contexto
        /// </summary>
        private readonly InlockContext ctx;
        /// <summary>
        /// construtor do repositorio
        /// toda vez que o repositorio 
        /// </summary>
        public UsuarioRepository()
        {
            ctx =new InlockContext();
        }
        public Usuario BuscarUsario(string Email, string Senha)
        {
            //acessa a tabela usuario e busca comparando o email 
            Usuario usuarioBuscado = ctx.Usuario.FirstOrDefault(u => u.Email == Email);

            //chama o método da classe criptografia ; condição para conferir se a senha digitada é igual a senha que esta no Banco
            try
            {
                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(Senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }

                }

                return null;
            }

            catch(Exception ex) 
            {
                throw;
            }
         } 
                

        public void Cadastrar(Usuario usuario)
        {
            try
            {
             usuario.Senha= Criptografia.GerarHash(usuario.Senha!);

             ctx.Usuario.Add(usuario);

             ctx.SaveChanges();

            }

            catch (Exception )
            {
                throw;
            }
        }
    }
}
