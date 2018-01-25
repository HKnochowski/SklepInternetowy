using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class GameType
    {
        public int GameTypeId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwę kategorii")]
        [StringLength(50)]
        public string NameGameType { get; set; }
        [Required(ErrorMessage = "Wprowadz opis kategorii")]
        public string DescriptionGameType { get; set; }
        public string FileGameType { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}