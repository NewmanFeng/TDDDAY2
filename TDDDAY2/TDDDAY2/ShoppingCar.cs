using System.Collections.Generic;
using System.Linq;

namespace TDDDAY2
{
    internal class ShoppingCar
    {
        protected List<Book> _books;
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
            var price = 0m;
            while (GetBookCount() > 0)
            {
                price += SinglePrice * GetBookCount() * GetDiscount(GetBookCount());
                RemoveCountedBook();
            }
            return price;
        }

        private int GetBookCount()
        {
            return _books.Count(book => book.Count > 0);
        }

        private void RemoveCountedBook()
        {
            foreach (var book in _books)
            {
                book.Count = book.Count - 1;
            }
        }

        private decimal GetDiscount(int count)
        {
            if (count == 0 || count > 5)
                return 1;
            return DiscountInfo[count];
        }
    }
}