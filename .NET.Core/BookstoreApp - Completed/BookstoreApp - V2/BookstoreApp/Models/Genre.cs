using System.ComponentModel.DataAnnotations;

namespace BookstoreApp.Models
{
    public class Genre
    {
        [Key]
        public string GenreID { get; set; }

        public string Name { get; set; }
    }
}
