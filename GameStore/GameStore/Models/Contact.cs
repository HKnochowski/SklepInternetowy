using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public virtual ICollection<Employer> Employer { get; set; }
    }
}