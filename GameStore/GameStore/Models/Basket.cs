using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Basket
    {
        public int BasketId { get; set; }
        public int CodeBasket { get; set; }
        public decimal Price { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime AddedDate { get; set; }

        List<Copie> Copie { get; set; }
        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<SalesInvoice> SalesInvoice { get; set; }


    }

    public enum OrderStatus
    {
        Czeka_na_płatność,
        Zakończone
    }
}