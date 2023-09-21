using System.ComponentModel.DataAnnotations;

namespace apiweb._event.manha.ViewModel
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Email de Usuario obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha de Usuario obrigatório")]
        public string Senha { get; set; }
    }
}
