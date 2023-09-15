using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;

namespace senai.inlock.webApi.Domains
{
    public class UsuariosDomain
    {
 //       IdUsuario INT PRIMARY KEY IDENTITY
	//,IdTipoUsuario INT FOREIGN KEY REFERENCES TiposUsuario(IdTipoUsuario)
	//,Email VARCHAR(100) NOT NULL UNIQUE
	//,Senha VARCHAR(100) NOT NULL

        public int IdUsuario { get; set; }

       public int IdTipoUsuario { get; set; }

        [Required(ErrorMessage ="O email é Obrigatório!!")]
        public string Email { get; set; }

        [StringLength(10, MinimumLength = 3, ErrorMessage = "A senha deve ter de 4 á 10 caracteres")]
        [Required(ErrorMessage = "o Campo Senha é Obrigatório!!")]
        public string Senha { get; set; }

        public string Permissao { get; set; }

    }
}
