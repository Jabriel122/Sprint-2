﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiweb._event.manha.Domains
{
    [Table(nameof(ComentariosEventos))]
    public class ComentariosEventos
    {
        [Key]

        public Guid IdComentarioEventos { get; set; } = Guid.NewGuid();


        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A descrição é obrigatória")]
        public string? Descricao { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "A informação de exibição é obrigatória!")]
        public bool Exibe { get; set; }

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
