using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public int GameTypeId { get; set; }
        [Required( ErrorMessage = "Wprowadz nazwę gry")]
        [StringLength(50)]
        public string GameName { get; set; }
        [Required(ErrorMessage = "Wprowadz opis gry")]
        public string GameDescription { get; set; }
        [Required( ErrorMessage ="Wprowadz datę premiery gry")]
        public DateTime GamePremiere { get; set; }
        public int GameRating { get; set; }
        public bool OrToBuy { get; set; }

        public virtual GameType GameType { get; set; }
    }
}