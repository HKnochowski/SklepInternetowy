using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameStore.Models
{
    [DataContract]
    public class SystemRequir
    {
        [DataMember]
        public int SystemRequirID { get; set; }
        [DataMember]
        public string Procesor { get; set; }
        [DataMember]
        public int MemmoryRam { get; set; }
        [DataMember]
        public string Graphics { get; set; }
        [DataMember]
        public int Storage { get; set; }
        [DataMember]
        public int Games_GameID { get; set; }
        [DataMember]
        public virtual Game Game { get; set; }
    }
}