using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class Gallery
    {
        [DataMember]
        public int GalleryID { get; set; }
        [DataMember]
        public string NameGallery { get; set; }
        [DataMember]
        public DateTime DateAddGalery { get; set; }
        [DataMember]
        public virtual ICollection<Game> Game { get; set; }
        [DataMember]
        public virtual ICollection<Image> Image { get; set; }
        [DataMember]
        public virtual ICollection<Video> Video { get; set; }
    }
}