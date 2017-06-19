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
            var price = SinglePrice*totalCount*GetDiscount(totalCount);

            //if (totalCount == 1)
            //{
            //    price = SinglePrice * totalCount ;
            //}
            //else if (totalCount == 2)
            //{
            //    price = SinglePrice * totalCount * 0.95m;
            //}
            //else if(totalCount==3)
            //{
            //    price = SinglePrice*totalCount*0.9m;
            //}
            //else if(totalCount==4)
            //{
            //    price = SinglePrice * totalCount * 0.8m;
            //}
            //else if (totalCount == 5)
            //{
            //    price = 100 * totalCount * 0.75m;
            //}
            return price;
        }

        private decimal GetDiscount(int totalCount)
        {

            if (totalCount == 1)
            {
                return 1;
            }
            else if (totalCount == 2)
            {
            return 0.95m;
            }
            else if (totalCount == 3)
            {
                return 0.9m;
            }
            else if (totalCount == 4)
            {
                return 0.8m;
            }
            else if (totalCount == 5)
            {
                return 0.75m;
            }
            return 1;
        }
    }
}