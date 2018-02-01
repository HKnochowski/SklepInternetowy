using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class Basket
    {
        [DataMember]
        public int BasketId { get; set; }
        [DataMember]
        public int CodeBasket { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public OrderStatus OrderStatus { get; set; }
        [DataMember]
        public DateTime AddedDate { get; set; }
        [DataMember]

        List<Copie> Copie { get; set; }


    }

    public enum OrderStatus
    {
        Czeka_na_płatność,
        Zakończone
    }
}