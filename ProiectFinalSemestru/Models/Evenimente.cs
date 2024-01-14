using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using ProiectFinalSemestru.Models;

namespace ProiectFinalSemestru.Models
{
    public class Evenimente
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nume { get; set; }
        public DateTime Data { get; set; }
        public string Locatie { get; set; }
        [ForeignKey(nameof(Speaker))]
        public  string SpeakerSelected { get; set; }
        [ForeignKey(nameof(Sponsor))]
        public string SponsorSelected { get; set; }
        [ForeignKey(nameof(Partener))]
        public  string PartenerSelected{ get; set; }
        [ForeignKey(nameof(Categorie))]
        public  string CategorieSelected{ get; set; }
    }
}
