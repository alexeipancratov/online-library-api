using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineLibrary.Data;

namespace OnlineLibrary.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return new Book[]
            {
                new Book { Id = 1, Title = "A Brief History of Time" },
                new Book { Id = 2, Title = "Cooking Book by Martha" },
                new Book { Id = 3, Title = "Where to travel?" }
            };
        }
    }
}
