using LibraryApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Data
{
    public class LibraryAPIContext : DbContext
    {
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public LibraryAPIContext(DbContextOptions<LibraryAPIContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Library>().HasDiscriminator(u => u.Type);
        }

    }
}
