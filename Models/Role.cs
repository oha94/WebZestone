using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebZstone.Models
{
    [Table("role")]
    public class Role
    {
        [Key]
        public int IdR { get; set; }
        public string LibR { get; set; }
    }
}
