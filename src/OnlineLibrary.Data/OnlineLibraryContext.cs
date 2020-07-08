using Microsoft.EntityFrameworkCore;
using OnlineLibrary.Domain;

namespace OnlineLibrary.Data
{
    public class OnlineLibraryContext : DbContext
    {
        public OnlineLibraryContext(DbContextOptions<OnlineLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<SoldBook> SoldBooks { get; set; }
    }
}
