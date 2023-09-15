using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    public class EstudiosDomain
    {
        //   IdEstudio INT PRIMARY KEY IDENTITY
        //Nome VARCHAR(100) NOT NULL

        public int IdEstudio { get; set; }

        [Required(ErrorMessage = "o nome do Estudio é obrigatório")]
        public string Nome { get; set; }


    }
}
