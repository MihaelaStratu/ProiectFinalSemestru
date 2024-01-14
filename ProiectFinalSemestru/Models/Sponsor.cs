using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ProiectFinalSemestru.Models
{
    public class Sponsor
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [Unique]
        public string? Name { get; set; }
        [MaxLength(100)] 
        public string? Description { get; set; }
        public string? Contact { get; set; }
        public string? Adresa_email { get; set; }     
    }
}
