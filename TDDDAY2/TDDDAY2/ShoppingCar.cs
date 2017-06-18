using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace TDDDAY2
{
    internal class ShoppingCar
    {
        private List<Book> _books;
        protected readonly decimal SinglePrice = 100m;

        public ShoppingCar()
        {
            _books = new List<Book>();
        }

        public void Buy(Book book)
        {
            _books.Add(book);

        }

        public decimal GetPrice()
        {
            var totalCount = _books.Sum(book => book.count);
            var price = 0m;

            if (totalCount == 1)
            {
                price = 100m;
            }
            else if (totalCount == 2)
            {
                price = 100 * totalCount * 0.95m;
            }
            return price;
        }
    }
}