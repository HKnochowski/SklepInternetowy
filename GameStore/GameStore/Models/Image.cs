using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class Image
    {
        [DataMember]
        public int ImageID { get; set; }
        [DataMember]
        public string NameImage { get; set; }
        [DataMember]
        public DateTime DateAddImage { get; set; }
        [DataMember]
        public virtual ICollection<Gallery> Gallery { get; set; }
    }
}