using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class State
    {
        public int StateID { get; set; }
        public string StateName { get; set; }
        public virtual ICollection<Client> Client { get; set; }
    }
}