using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dominios.Classes
{
    public class Alas
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Titulo", TypeName = "varchar(255)")]
        public string Titulo { get; set; }

        [Required]
        [Column("Descricao", TypeName = "varchar(255)")]
        public string Descricao { get; set; }

        [ForeignKey("Sensores")]
        [Column("IdSensor", TypeName = "int")]
        public int IdSensor { get; set; }
        public Sensores Sensor { get; set; }

        
        [ForeignKey("Eventos")]
        [Column("IdEvento", TypeName = "int")]
        public int IdEvento { get; set; }
        public Eventos Evento { get; set; }


    }
}
