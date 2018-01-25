using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Copie
    {
        public int CopieId { get; set; }
        public int BasketId { get; set; }
        public int GameId { get; set; }
        public int CodeCopie { get; set; }
        public bool OrToSale { get; set; }
        public decimal PriceCopie { get; set; } 

        public virtual Game Game { get; set; }
        public virtual Basket Basket { get; set; }
    }
}