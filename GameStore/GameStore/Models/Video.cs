using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class Video
    {
        [DataMember]
        public int VideoID { get; set; }
        [DataMember]
        public string VideName{ get; set; }
        [DataMember]
        public DateTime DateAddVideo { get; set; }
        [DataMember]
        public virtual ICollection<Gallery> Gallery { get; set; }
    }
}