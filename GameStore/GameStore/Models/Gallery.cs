using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Gallery
    {
        public int GalleryID { get; set; }
        public string NameGallery { get; set; }
        public DateTime DateAddGalery { get; set; }
        public virtual ICollection<Game> Game { get; set; }
        public virtual ICollection<Image> Image { get; set; }
        public virtual ICollection<Video> Video { get; set; }
    }
}