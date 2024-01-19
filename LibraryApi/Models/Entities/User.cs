namespace LibraryApi.Models.Entities
{
    public class User : Library
    {
        public ICollection<Book> Books { get; set; }
    }
}
