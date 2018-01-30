using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class SalesInvoice
    {
        public int SaleInvoiceID { get; set; }
        public int CodeSaleInvoice { get; set; }
        public long Price { get; set; }
        public int Baskets_BasketID { get; set; }
        public int Clients_ClientID { get; set; }

         


        public virtual Basket Basket { get; set; }
        public virtual Client Client { get; set; }
    }
}