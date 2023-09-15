using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codeFirst.manha.Domain
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique = true)] //Criar um índice único para 
    public class Usuario
    {
        [Key]

        public Guid IdUsuario { get; set; } = Guid.NewGuid();


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email de Usuario obrigatório")]
        public string Email { get; set; }


        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = "Senha de Usuario obrigatório")]
        [StringLength(200, MinimumLength = 6, ErrorMessage = "A Senha deve conter de 6 á 20 caracteres")]
        public string? Senha { get; set;  }

        //Referencia a chave a estrangeira (Tabela de TipoUsuario)

        [Required(ErrorMessage = "Tipo Usuario obrigatório")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey("IdTipoUsuario")]
        public TipoUsuario? TipoUsuario { get; set; }



    }
}
