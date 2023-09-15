using System.ComponentModel.DataAnnotations;

namespace webapi.inlock.codeFirst.manha.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email de Usuario obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha de Usuario obrigatório")]
        public string Senha { get; set; }
    }
}
