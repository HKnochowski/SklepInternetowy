using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class Platform
    {
        [DataMember]
        public int PlatformID { get; set; }
        [DataMember]
        public string NamePlatform { get; set; }
        [DataMember]
        public virtual ICollection<Game> Game { get; set; }
        [DataMember]
        public virtual ICollection<PlatformType> PlatformType { get; set; }
    }
}