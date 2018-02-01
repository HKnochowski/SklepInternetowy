using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public int AddressID { get; set; }
        [DataMember]
        public string Voivodeship { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Town { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public string HouseNumber { get; set; }
        [DataMember]
        public string AppartmentNumber { get; set; }
        [DataMember]
        public int EmployersEmployersID { get; set; }
        [DataMember]
        public int Clients_ClientID { get; set; }

        [DataMember]
        public virtual Client Client { get; set; }
        [DataMember]
        public virtual Employer Employers { get; set; }
    }
}