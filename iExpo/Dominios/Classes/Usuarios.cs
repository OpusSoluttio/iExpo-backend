using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dominios.Classes
{
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Email", TypeName = "varchar(150)")]
        [MinLength(4, ErrorMessage = "O email deve ter no mínimo 4 caracteres")]
        public string Email { get; set; }

        [Required]
        [Column("Senha", TypeName = "varchar(255)")]
        [MinLength(6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres")]
        [MaxLength(24, ErrorMessage = "A senha deve ter no máximo 24 caracteres")]
        public string Senha { get; set; }

        [Column("Nome", TypeName = "varchar(150)")]
        public string Nome { get; set; }
    }
}
