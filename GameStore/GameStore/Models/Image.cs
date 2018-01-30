using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Image
    {
        public int ImageID { get; set; }
        public string NameImage { get; set; }
        public DateTime DateAddImage { get; set; }
        public virtual ICollection<Gallery> Gallery { get; set; }
    }
}