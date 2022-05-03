using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumsApp.Models
{
    public class Studio
    {
        public int StudioId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }
    }
}
