using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebZstone.Models
{
    [Table("ville")]
    public class Ville
    {
        [Key]
        public int IdV { get; set; }
        [DisplayName("Libelle")] 
        [Required(ErrorMessage ="Champs Obligatoire", AllowEmptyStrings =false)]
        public string Lib { get; set; }
    }
}
