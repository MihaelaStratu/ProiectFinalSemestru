using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ProiectFinalSemestru.Models
{
   public class Categorie
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        [Unique]
        public string Denumire { get; set; }
        public string Descriere { get; set; }
    }
}
