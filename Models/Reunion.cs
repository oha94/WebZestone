using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebZstone.Models
{
    [Table("reunion")]
    public class Reunion
    {
        [Key]
        public int IdRe { get; set; }
        public int LibRe { get; set; }
    }
}
