using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class GamePublisher
    {
        public int GamePublisherID { get; set; }
        public string NamaGamePublisher { get; set; }
        public virtual ICollection<Game> Game { get; set; }
    }
}