using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public int ClientID { get; set; }
        [DataMember]
        public string LoginClient { get; set; }
        [DataMember]
        public string PasswordClient { get; set; }
        [DataMember]
        public string NameClient { get; set; }
        [DataMember]
        public string SurnameClient { get; set; }
        [DataMember]
        public string Avatar { get; set; }
        [DataMember]
        public bool IsLoggedIn { get; set; }
        [DataMember]
        public bool IsBanned { get; set; }
        [DataMember]
        public int StateStateID { get; set; }
        [DataMember]
        public int Basket_BasketID { get; set; }
        [DataMember]
        public virtual ICollection<Address> Address { get; set; }
        [DataMember]

        public virtual Basket Basket { get; set; }
        [DataMember]
        public virtual ICollection<SalesInvoice> SalesInvoice { get; set; }
        [DataMember]

        public virtual State State { get; set; }
        [DataMember]
        public virtual ICollection<Copie> Copie { get; set; }
        [DataMember]
        public virtual ICollection<WishList> WishList { get; set; }
    }
}