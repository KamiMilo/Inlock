using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inlock_codefirst.Domains
{
    [Table ("TipoUsuario")]
    public class TipoUsuario
    {
        [Key]

        public Guid IdTipoUsuario { get; set; }

        [Column(TypeName ="VARCHAR(50)")]
        [Required(ErrorMessage ="O nome do usuario é Obrigatório")]
        public string? Titulo { get; set; }

    }
}
