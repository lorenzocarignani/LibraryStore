namespace LibraryApi.Models.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string Title { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
    }
}
