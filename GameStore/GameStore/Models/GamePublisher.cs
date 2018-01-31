using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class GamePublisher
    {
        public int GamePublisherID { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwę wydawcy")]
        [StringLength(80)]
        public string NamaGamePublisher { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}