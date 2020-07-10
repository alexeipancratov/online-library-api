using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineLibrary.Data;
using OnlineLibrary.Domain;
using OnlineLibrary.Services;
using OnlineLibrary.WebApi.Models.Books;

namespace OnlineLibrary.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly IBooksService _booksService;
        private readonly OnlineLibraryContext _context;

        public BooksController(ILogger<BooksController> logger, IBooksService booksService, OnlineLibraryContext context)
        {
            _logger = logger;
            _booksService = booksService;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _context.Books.ToList();
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateBookViewModel model)
        {
            var book = new Book
            {
                Author = model.Author,
                RentPrice = model.RentPrice,
                SalePrice = model.SalePrice,
                Title = model.Title
            };

            bool isSuccess = await _booksService.SaveBook(book);

            if (isSuccess)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
