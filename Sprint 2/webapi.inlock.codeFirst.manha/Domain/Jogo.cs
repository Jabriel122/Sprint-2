using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codeFirst.manha.Domain
{
    /// <summary>
    /// Classe que representa a entidade Jogo
    /// </summary>

    [Table("Jogo")]
    public class Jogo
    {
        [Key]

        public Guid IdJogo { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do jogo é obrigatório")]
        public string Nome { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descrilção do jogo é obrigatório")]
        public string Descricao { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data de Lançamento é obrigatório")]
        public DateTime DataLancamento { get; set; }

        [Column(TypeName = "DECIMAL(4,2)")]
        [Required(ErrorMessage = "Preço é obrigatório")]
        public decimal? Preco { get; set; }


        //Referencia da Chave-Estrangeira (Tebela de Estúdio)
        [Required(ErrorMessage = "informe o Estúdio que produziu o jogo")]
        public Guid IdEstudio { get; set; }

        [ForeignKey("IdEstudio")]
        public Estudio Estudio { get; set; }



    }
}
