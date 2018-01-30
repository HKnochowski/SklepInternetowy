﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Voivodeship { get; set; }
        public string Country { get; set; }
        public string Town { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string AppartmentNumber { get; set; }
        public int EmployersEmployersID { get; set; }
        public int Clients_ClientID { get; set; }

        public virtual Client Client { get; set; }
        public virtual Employer Employers { get; set; }
    }
}