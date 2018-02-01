using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class WishList
    {
        [DataMember]
        public int WishListID { get; set; }
        [DataMember]
        public int CodeWishList { get; set; }
        [DataMember]
        public int Games_GameID { get; set; }
        [DataMember]
        public virtual Game Game { get; set; }
        [DataMember]
        public virtual ICollection<Client> Client { get; set; }
    }
}