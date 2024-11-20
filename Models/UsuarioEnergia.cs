﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GsDotNet.Models
{
    [Table("USUARIO_ENERGIA")]
    public class UsuarioEnergia
    {
        [Key]
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }

        [Required]
        [Column("NOME")]
        [MaxLength(255)]
        public string Nome { get; set; }

        [Required]
        [Column("EMAIL")]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        [Column("SENHA")]
        [MaxLength(255)]
        public string Senha { get; set; }

        public virtual ICollection<ConsumoEnergia>? Consumos { get; set; } = new List<ConsumoEnergia>();
    }
}
