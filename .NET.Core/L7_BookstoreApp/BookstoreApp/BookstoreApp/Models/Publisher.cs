using System.ComponentModel.DataAnnotations;

namespace BookstoreApp.Models
{
    public class Publisher
    {
        [Key]
        public string PublisherID { get; set; }

        public string Name { get; set; }
    }
}
