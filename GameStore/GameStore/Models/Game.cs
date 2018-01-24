using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public int GameTypeId { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public DateTime GamePremiere { get; set; }
        public int GameRating { get; set; }
        public bool OrToBuy { get; set; }

        public virtual GameType GameType { get; set; }
    }
}