using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class Copie
    {
        [DataMember]
        public int CopieId { get; set; }
        [DataMember]
        public int BasketId { get; set; }
        [DataMember]
        public int GameId { get; set; }
        [DataMember]
        public int CodeCopie { get; set; }
        [DataMember]
        public bool OrToSale { get; set; }
        [DataMember]
        public decimal PriceCopie { get; set; }
        [DataMember]

        public virtual Game Game { get; set; }
        [DataMember]
        public virtual Basket Basket { get; set; }
    }
}