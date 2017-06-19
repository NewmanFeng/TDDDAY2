using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace TDDDAY2
{
    internal class ShoppingCar
    {
        private List<Book> _books;
        protected readonly decimal SinglePrice = 100m;

        protected Dictionary<int, decimal> DiscountInfo = new Dictionary<int, decimal>()
        {
            {1,1 },
            {2,0.95m },
            {3,0.9m },
            {4,0.8m },
            {5,0.75m }
        };

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
            var price = SinglePrice * totalCount * GetDiscount(totalCount);
            return price;
        }

        private decimal GetDiscount(int count)
        {
            if (count == 0 || count > 5)
                return 1;
            return DiscountInfo[count];
        }
    }
}