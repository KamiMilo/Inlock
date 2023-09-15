using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inlock_codefirst.Domains
{
     [Table("Estudio")]
    public class Estudio
    {
        [Key]
        public Guid IdEstudio { get; set; } = Guid.NewGuid();

        //aqui é definido que cada classe será uma tabela
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage ="O nome do Estudio é obrigatorio!")]
        public string? Nome { get; set; }

        public List<Jogo>? Jogo { get; set; }
        




    }
}
