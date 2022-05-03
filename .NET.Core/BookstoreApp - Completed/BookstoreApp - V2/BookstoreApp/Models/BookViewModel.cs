namespace BookstoreApp.Models
{
    public class BookViewModel
    {
        public Book Book { get; set; }
        public string ActiveGenre { get; set; } = "all";
        public string ActiveAuthor { get; set; } = "all";
        public string ActivePublisher { get; set; } = "all";
    }
}
