using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiweb._event.manha.Domains
{
    [Table(nameof(Evento))]
    public class Evento
    {
        [Key]

        public Guid IdEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data deve ser mencionada")]
        public DateTime DataEvento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage ="Nome do Evento obrigatório")]
        public string? NomeEvento { get; set; }


        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descrição do evento obrigatório")]
        public string? Descricao { get; set; }


        //ref.tabela TiposEvento = FK
        [Required(ErrorMessage = "Id do tipo evento é obrigatório")]
        public Guid IdTiposEvento { get; set; }

        [ForeignKey(nameof(IdTiposEvento))]

        public TiposEvento? TiposEvento { get; set; }

        //ref.tabela.Instituicao
        [Required(ErrorMessage = "Instituição é obrigatório")]
        public Guid IdInstituicao { get; set; }

        [ForeignKey(nameof(IdInstituicao))]

        public Instituicao? Instituicao { get; set; }

    }
}
