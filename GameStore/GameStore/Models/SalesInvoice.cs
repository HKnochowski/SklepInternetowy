using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class SalesInvoice
    {
        public int SalesInvoiceId { get; set; }
        public int CodeSalesInvoice { get; set; }
        public decimal Price { get; set; }
        public OrderStatus OrderStatus { get; set; }


    }

    public enum OrderStatus
    {
        Czeka_na_płatność,
        Zakończone
    }
}