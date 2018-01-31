using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class SystemRequir
    {
        public int SystemRequirID { get; set; }
        public string Procesor { get; set; }
        public int MemmoryRam { get; set; }
        public string Graphics { get; set; }
        public int Storage { get; set; }
        public int Games_GameID { get; set; }
        public virtual ICollection<Game> Game { get; set; }
    }
}