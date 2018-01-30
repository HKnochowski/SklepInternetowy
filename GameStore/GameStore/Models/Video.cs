using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Video
    {
        public int VideoID { get; set; }
        public string VideName{ get; set; }
        public DateTime DateAddVideo { get; set; }
        public virtual ICollection<Gallery> Gallery { get; set; }
    }
}