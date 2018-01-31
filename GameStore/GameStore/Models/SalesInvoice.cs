using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Models
{
    [Table("SalesInvoices")]
    public class SalesInvoice
    {
        [Key]
        public int SaleInvoiceID { get; set; }
        public int CodeSaleInvoice { get; set; }
        public long Price { get; set; }
        public virtual Basket Basket { get; set; }
        public virtual ICollection <Client> Client { get; set; }
    }
}