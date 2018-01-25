using System.Collections;
using System.Collections.Generic;

namespace GameStore.Models
{
    public class GameType
    {
        public int GameTypeId { get; set; }
        public string NameGameType { get; set; }
        public string DescriptionGameType { get; set; }
        public string FileGameType { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}