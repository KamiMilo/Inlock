using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inlock_codefirst.Domains
{
    /// <summary>
    /// Classe que representa a tabela jogo
    /// </summary>
    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        public Guid IdJogo { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do Jogo é obrigatorio!")]
        public string? Nome { get; set;}

        [Column(TypeName ="TEXT")]
        [Required(ErrorMessage = "Descrição do Jogo é obrigatorio!")]
        public string? Descricao { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data de lançamento do Jogo é obrigatorio!")]
        public DateTime? DataDeLancamento { get; set; }

        [Column(TypeName = "Decimal(4,2)")]
        [Required(ErrorMessage = "O preco do Jogo é obrigatorio!")]

        public decimal? Preco { get; set; }

        //tabela que referencia a Chave estrangeira(Tabela de Estudio)
        [Required(ErrorMessage = "Informe o estudio que produziu o jogo!")]
        public Guid IdEstudio { get; set; }

        [ForeignKey("IdEstudio")]
        public Estudio? Estudio { get; set; }





    }
}
