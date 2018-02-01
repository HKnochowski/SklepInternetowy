using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class State
    {
        [DataMember]
        public int StateID { get; set; }
        [DataMember]
        public string StateName { get; set; }
        [DataMember]
        public virtual ICollection<Client> Client { get; set; }
    }
}