using OnlineLibrary.Domain;
using System.Threading.Tasks;

namespace OnlineLibrary.Services
{
    public interface IBooksService
    {
        Task<bool> SaveBook(Book book);
    }
}
