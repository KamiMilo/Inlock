using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inlock_codefirst.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email),IsUnique = true)] //cria um indice único para a tabela email
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="O email é Obrigatório")]
        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = "A Senha é obrigatoria")]
        [StringLength(200,MinimumLength =6, ErrorMessage = "A Senha Deve conter de 6 á 20 caracteres")]

        public string? Senha { get; set; }

        //Referência da Chave estrangeira (Tabela de TiposUsuario)

        [Required(ErrorMessage = "Tipo do usuário obrigatório")]
        public Guid IdTipoUsuario { get; set; }


        [ForeignKey("IdTipoUsuario")]
        public TipoUsuario? tipoUsuario { get; set; }

    }
}
