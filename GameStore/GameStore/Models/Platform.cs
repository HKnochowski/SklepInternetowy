using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Platform
    {
        public int PlatformID { get; set; }
        public string NamePlatform { get; set; }
        public virtual ICollection<Game> Game { get; set; }
        public virtual PlatformType PlatformType { get; set; }
    }
}