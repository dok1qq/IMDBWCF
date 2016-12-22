using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IMDBWCF.Models
{
    [DataContract]
    public class Film
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Director { get; set; }
        [DataMember]
        public string Poster { get; set; }
        [DataMember]
        public string Rating { get; set; }
    }
}
