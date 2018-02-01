using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GameStore.Models
{
    [DataContract]
    public class GameType
    {
        [DataMember]
        public int GameTypeId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwę kategorii")]
        [StringLength(50)]
        [DataMember]
        public string NameGameType { get; set; }
        [Required(ErrorMessage = "Wprowadz opis kategorii")]
        [DataMember]
        public string DescriptionGameType { get; set; }
        [DataMember]
        public string FileGameType { get; set; }
        [DataMember]

        public virtual ICollection<Game> Games { get; set; }
    }
}