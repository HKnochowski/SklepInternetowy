using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class Employer
    {
        [DataMember]
        public int EmployerID { get; set; }
        [DataMember]
        public string EmployerLogin { get; set; }
        [DataMember]
        public string EmployerPassword { get; set; }
        [DataMember]
        public string EmployerName { get; set; }
        [DataMember]
        public string EmployerSurname { get; set; }
        [DataMember]
        public bool ActiveAccount { get; set; }
        [DataMember]
        public DateTime HireDate { get; set; }
        [DataMember]
        public DateTime DismissDate { get; set; }
        [DataMember]
        public int ContactsContactID { get; set; }
        [DataMember]
        public virtual ICollection<Address> Address { get; set; }
        [DataMember]
        public virtual Contact Contact { get; set; }
    }
}