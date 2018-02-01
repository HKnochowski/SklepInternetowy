using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class Contact
    {
        [DataMember]
        public int ContactID { get; set; }
        [DataMember]
        public string PhoneNumber1 { get; set; }
        [DataMember]
        public string PhoneNumber2 { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Website { get; set; }
        [DataMember]
        public virtual ICollection<Employer> Employer { get; set; }
    }
}