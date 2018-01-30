using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class GameLanguage
    {
        public int IDGameLanguage { get; set; }
        public string NameLanguage { get; set; }
        public virtual ICollection<Game> Game { get; set; }
    }
}