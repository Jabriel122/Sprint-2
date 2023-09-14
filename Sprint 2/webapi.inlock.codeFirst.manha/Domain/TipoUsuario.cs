﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codeFirst.manha.Domain
{
    [Table("TipoUsuario")]
    public class TipoUsuario
    {
        [Key]

        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Tipo do Usuario obrigatório!")]

        public string Titulo { get; set; }

    }
}
