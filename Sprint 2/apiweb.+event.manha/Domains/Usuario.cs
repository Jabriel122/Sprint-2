using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiweb._event.manha.Domains
{
    [Table(nameof(Usuario))]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        [Key]

        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do usuário obrigatório")]

        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email usuário obrigatório")]

        public string? Email { get; set; }

        [Column(TypeName = "CHAR(60)")]
        [Required(ErrorMessage = "Senha de usuário obrigatório")]
        [StringLength(60, MinimumLength =6, ErrorMessage ="Senha deve conter de 6 a 60 caracteres")]

        public string? Senha { get; set; }

       
        [Required(ErrorMessage = "Informe o tipo de usuario")]

        public Guid IdTipoDeUsuario { get; set; }

        [ForeignKey(nameof(IdTipoDeUsuario))]
        //[ForeignKey("IdTipoUsuario")]

        public TiposUsuario? TiposUsuario { get; set; } 
    }
}
