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
    public class Partener
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [Required,Unique]
        [Display(Name = "Partener Nume")]
        public string? Nume { get; set; }

        [Required]
        public string? Contact { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        public string? Descriere { get; set; }
       // public int? EvenimentID { get; set; }  // Added SponsorID property
        
    }
}

