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
        public bool OrRecommended { get; set; }
        public string NameFileNews { get; set; }
        public string NameFileBestseller { get; set; }
        public string NameFileRecomended { get; set; }

        public virtual GameType GameType { get; set; }
        public virtual GameLanguage GameLanguage { get; set; }
        public virtual GamePublisher GamePublisher { get; set; }
    }
}