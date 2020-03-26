using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dominios.Classes
{
    public class Eventos
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Nome", TypeName = "varchar(255)")]
        public string Nome { get; set; }

        [Required]
        [Column("DataInicio", TypeName = "date")]
        public DateTime DataInicio { get; set; }

        [Required]
        [Column("DataFim", TypeName = "date")]
        public DateTime DataFim { get; set; }

        [Required]
        [Column("Endereco", TypeName = "varchar(255)")]
        public string Endereco { get; set; }

    }
}
