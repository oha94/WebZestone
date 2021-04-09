using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebZstone.Models
{
    [Table("participant")]
    public class Participant
    {
        [Key]
        public int Idpart { get; set; }
        public string Login { get; set; }
        public string Pwd { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string contact { get; set; }
        public DateTime dateNaiss { get; set; }
        public char genre { get; set; }
        [ForeignKey("idr")]
        public int IdR { get; set; }
        [ForeignKey("idv")]
        public int IdV { get; set; }
    }
}
