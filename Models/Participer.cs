using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebZstone.Models
{
    [Table("table")]
    public class participer
    {
        [Key]
        public int IdPart { get; set; }
        public DateTime date { get; set; }
        [ForeignKey("idpart")]
        public int Idpart { get; set; }
        [ForeignKey("idre")]
        public int IdRe { get; set; }
    }
}
