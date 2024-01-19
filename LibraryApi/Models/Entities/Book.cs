using LibraryApi.Models.Enums;

namespace LibraryApi.Models.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Resume { get; set; }
        public int Ratings { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public BookState State { get; set; } = BookState.Enabled;
        public CategoryBook Category { get; set; } = CategoryBook.Generic;
    }
}
