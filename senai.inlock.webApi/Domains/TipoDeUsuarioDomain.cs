using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    public class TipoDeUsuarioDomain
    {
        public int IdTipoDeUsuario { get; set; }

        [Required(ErrorMessage = "O tipo de usuário é obrigatório!")]
        public string Titulo { get; set; }

    }
}
