using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class PlatformType
    {
        public int PlatformTypeID { get; set; }
        public string NamePlatformType { get; set; }
        public virtual ICollection<Platform> Platform { get; set; }
    }
}