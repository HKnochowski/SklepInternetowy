using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class GameLanguage
    {
        [DataMember]
        public int IDGameLanguage { get; set; }
        [DataMember]
        public string NameLanguage { get; set; }
        [DataMember]

        public virtual ICollection<Game> Game { get; set; }
    }
}