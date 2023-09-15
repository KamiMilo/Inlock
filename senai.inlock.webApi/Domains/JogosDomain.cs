using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Security.Cryptography.Xml;
using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    public class JogosDomain
    {
        //       IdJogo INT PRIMARY KEY IDENTITY
        //,IdEstudio INT FOREIGN KEY REFERENCES Estudio(IdEstudio)
        //,Nome VARCHAR(100) NOT NULL
        //   , Descricao VARCHAR(100) NOT NULL
        //   , DataLancamento DATE NOT NULL
        //,Valor SMALLMONEY NOT NULL

        public int IdJogo { get; set; }

        public EstudiosDomain? IdEstudio { get; set; }

        [Required(ErrorMessage = "o nome do jogo é obrigatório")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Date DataDeLacamento { get; set; }
        public float Valor { get; set; }


    }

}
