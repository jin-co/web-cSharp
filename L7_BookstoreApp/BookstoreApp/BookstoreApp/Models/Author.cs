using System.ComponentModel.DataAnnotations;

namespace BookstoreApp.Models
{
    public class Author
    {
        [Key]
        public string AuthorID { get; set; }

        public string FullName { get; set; }
    }
}
