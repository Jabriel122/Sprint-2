using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiweb._event.manha.Domains
{
    [Table(nameof(PresencasEvento))]
    public class PresencasEvento
    {
        [Key]

        public Guid IdPresencasEventos { get; set; } = Guid.NewGuid();


        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "Situação obrigatória")]
        public bool Situacao { get; set; }

        //ref.tabela Usuario = FK
        [Required(ErrorMessage = "Usuário obrigatória")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]

        public Usuario? Usuario { get; set; }

        //ref.tabela FK

        [Required(ErrorMessage = "Evento obrigatório!")]
        
        public Guid IdEvento { get; set; }

        [ForeignKey(nameof(IdEvento))]
        public Evento? Evento { get; set; }
    }
}
