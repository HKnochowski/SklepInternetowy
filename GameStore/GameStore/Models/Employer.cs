using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Employer
    {
        public int EmployerID { get; set; }
        public string EmployerLogin { get; set; }
        public string EmployerPassword { get; set; }
        public string EmployerName { get; set; }
        public string EmployerSurname { get; set; }
        public bool ActiveAccount { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime DismissDate { get; set; }
        public virtual Address Address { get; set; }
        public virtual Contact Contact { get; set; }
    }
}