using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ProiectFinalSemestru.Models
{
    public class Speaker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Speaker nume")]
        public string? Nume { get; set; }
        public string? Prezentare { get; set; }
        public string? Telefon { get; set; }
        public string? Email { get; set; }
       
    }
}

