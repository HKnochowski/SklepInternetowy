using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class WishList
    {
        public int WishListID { get; set; }
        public int CodeWishList { get; set; }
        public int Games_GameID { get; set; }
        public virtual ICollection<Game> Game { get; set; }
        public virtual ICollection<Client> Client { get; set; }
    }
}