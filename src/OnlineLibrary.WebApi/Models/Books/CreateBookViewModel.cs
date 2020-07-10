namespace OnlineLibrary.WebApi.Models.Books
{
    public class CreateBookViewModel
    {
        public string Title { get; set; }

        public decimal SalePrice { get; set; }

        public decimal RentPrice { get; set; }

        public string Author { get; set; }
    }
}
