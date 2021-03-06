﻿using System;
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
        public bool OrToBuy { get; set; }
        [DataMember]
        public bool OrRecommended { get; set; }
        [DataMember]
        public string NameFileNews { get; set; }
        [DataMember]
        public string NameFileBestseller { get; set; }
        [DataMember]
        public string NameFileRecomended { get; set; }
        [DataMember]

        public virtual GameType GameType { get; set; }
    }
}