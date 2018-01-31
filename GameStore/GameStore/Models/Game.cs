using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class Game
    {
        [DataMember]
        public int GameId { get; set; }
        [DataMember]
        public int GameTypeId { get; set; }
        [Required( ErrorMessage = "Wprowadz nazwę gry")]
        [StringLength(50)]
        [DataMember]
        public string GameName { get; set; }
        [Required(ErrorMessage = "Wprowadz opis gry")]
        [DataMember]
        public string GameDescription { get; set; }
        [Required( ErrorMessage ="Wprowadz datę premiery gry")]
        [DataMember]
        public DateTime GamePremiere { get; set; }
        [DataMember]
        public int GameRating { get; set; }
        [DataMember]
        public double GamePrice { get; set; }
        [DataMember]
        public bool OrToBuy { get; set; }
        public bool OrRecommended { get; set; }
        public string NameFileNews { get; set; }
        public string NameFileBestseller { get; set; }
        public string NameFileRecomended { get; set; }
        public string NameFileCategoryList { get; set; }

        public virtual GameType GameType { get; set; }
        public virtual GameLanguage GameLanguage { get; set; }
        public virtual GamePublisher GamePublisher { get; set; }
        public virtual Platform Platform { get; set; }
        public virtual SystemRequir SystemRequir { get; set; }
        public virtual Gallery Gallery { get; set; }
        public virtual WishList WishList { get; set; }
    }
}