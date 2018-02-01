using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class GamePublisher
    {
        [DataMember]
        public int GamePublisherID { get; set; }
        [DataMember]
        public string NamaGamePublisher { get; set; }
        [DataMember]
        public virtual ICollection<Game> Game { get; set; }
    }
}