using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dominios.Classes
{
    public class Sensores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Codigo", TypeName = "int")]
        public int Codigo { get; set; }

        [Required]
        [Column("Modelo", TypeName = "varchar(255)")]
        public string Modelo { get; set; }

        [Required]
        [Column("Titulo", TypeName = "varchar(255)")]
        public string Titulo { get; set; }

        [Required]
        [Column("Texto", TypeName = "varchar(255)")]
        public string Texto { get; set; }

        [Required]
        [Column("Status", TypeName = "varchar(255)")]
        public string Status { get; set; }


    }
}
