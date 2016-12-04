using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBWCF.Models
{
    public class Film
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string Poster { get; set; }
        public string Rating { get; set; }
    }
}
