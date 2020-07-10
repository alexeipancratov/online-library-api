using OnlineLibrary.Data;
using OnlineLibrary.Domain;
using System.Threading.Tasks;

namespace OnlineLibrary.Services
{
    public class BooksService : IBooksService
    {
        private readonly OnlineLibraryContext _context;

        public BooksService(OnlineLibraryContext context)
        {
            _context = context;
        }

        public async Task<bool> SaveBook(Book book)
        {
            if (book.RentPrice > 100)
            {
                return false;
            }

            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
