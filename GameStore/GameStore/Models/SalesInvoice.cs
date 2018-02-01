using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace GameStore.Models
{
    [DataContract]
    public class SalesInvoice
    {
        [DataMember]
        public int SaleInvoiceID { get; set; }
        [DataMember]
        public int CodeSaleInvoice { get; set; }
        [DataMember]
        public long Price { get; set; }
        [DataMember]
        public int Baskets_BasketID { get; set; }
        [DataMember]
        public int Clients_ClientID { get; set; }
        [DataMember]




        [DataMember]
        public virtual Basket Basket { get; set; }
        [DataMember]
        public virtual Client Client { get; set; }
    }
}