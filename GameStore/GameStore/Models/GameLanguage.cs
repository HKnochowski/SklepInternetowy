using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Models
{
    [Table("GamesLanguages")]
    public class GameLanguage
    {
        [Key]
        public int IDGameLanguage { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwę języka")]
        [StringLength(50)]
        public string NameLanguage { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}