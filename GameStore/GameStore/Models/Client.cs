﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string LoginClient { get; set; }
        public string PasswordClient { get; set; }
        public string NameClient { get; set; }
        public string SurnameClient { get; set; }
        public string Avatar { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool IsBanned { get; set; }
        public int StateStateID { get; set; }
        public int Basket_BasketID { get; set; }
        public virtual ICollection<Address> Address { get; set; }

        public virtual Basket Basket { get; set; }
        public virtual ICollection<SalesInvoice> SalesInvoice { get; set; }

        public virtual State State { get; set; }
        public virtual ICollection<Copie> Copie { get; set; }
        public virtual ICollection<WishList> WishList { get; set; }
    }
}