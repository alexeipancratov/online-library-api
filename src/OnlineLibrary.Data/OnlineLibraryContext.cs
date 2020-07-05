using Microsoft.EntityFrameworkCore;

namespace OnlineLibrary.Data
{
    public class OnlineLibraryContext : DbContext
    {
        public OnlineLibraryContext(DbContextOptions<OnlineLibraryContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Book> Books { get; set; }
    }
}
