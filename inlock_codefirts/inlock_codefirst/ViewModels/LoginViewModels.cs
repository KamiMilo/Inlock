using System.ComponentModel.DataAnnotations;

namespace inlock_codefirst.ViewModels
{
    public class LoginViewModels
    {
        [Required(ErrorMessage ="Email obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "a Senha é obrigatória")]
        public string Senha { get; set; }

    }
}
