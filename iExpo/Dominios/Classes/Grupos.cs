using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dominios.Classes
{
    public class Grupos
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("NomeGrupo", TypeName = "varchar(255)")]
        public string NomeGrupo { get; set; }

        [Required]
        [Column("NomeEmpresa", TypeName = "varchar(255)")]
        public string NomeEmpresa { get; set; }

        [Required]
        [Column("NomeProjeto", TypeName = "varchar(255)")]
        public string NomeProjeto { get; set; }

        [Required]
        [Column("Descricao", TypeName = "varchar(255)")]
        public string Descricao { get; set; }

        [Required]
        [Column("Foto", TypeName = "text")]
        public string Foto { get; set; }


        [ForeignKey("Alas")]
        [Column("IdAla", TypeName = "int")]
        public int IdAla { get; set; }
        public Alas Ala { get; set; }


    }
}
