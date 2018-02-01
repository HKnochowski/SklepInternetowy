using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class PlatformType
    {
        [DataMember]
        public int PlatformTypeID { get; set; }
        [DataMember]
        public string NamePlatformType { get; set; }
        [DataMember]
        public virtual ICollection<Platform> Platform { get; set; }
    }
}