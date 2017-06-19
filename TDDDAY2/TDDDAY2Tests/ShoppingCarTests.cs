using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDDAY2;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDDAY2.Tests
{
    [TestClass()]
    public class ShoppingCarTests
    {
        [TestMethod()]
        public void Buy_One_HarryPotter1_Price_Should_Match()
        {
            var target = new ShoppingCar();

            target.Buy(new Book("HarryPotter1", 1));
            target.Buy(new Book("HarryPotter2", 0));
            target.Buy(new Book("HarryPotter3", 0));
            target.Buy(new Book("HarryPotter4", 0));
            target.Buy(new Book("HarryPotter5", 0));

            var expected = 100m;
            Assert.AreEqual(expected, target.GetPrice());
        }

        [TestMethod()]
        public void Buy_One_HarryPotter1_One_HarryPotter2_Price_Should_Match()
        {
            var target = new ShoppingCar();

            target.Buy(new Book("HarryPotter1", 1));
            target.Buy(new Book("HarryPotter2", 1));
            target.Buy(new Book("HarryPotter3", 0));
            target.Buy(new Book("HarryPotter4", 0));
            target.Buy(new Book("HarryPotter5", 0));

            var expected = 190m;
            Assert.AreEqual(expected, target.GetPrice());
        }

        [TestMethod()]
        public void Buy_One_HarryPotter1_One_HarryPotter2_One_HarryPotter3_Price_Should_Match()
        {
            var target = new ShoppingCar();

            target.Buy(new Book("HarryPotter1", 1));
            target.Buy(new Book("HarryPotter2", 1));
            target.Buy(new Book("HarryPotter3", 1));
            target.Buy(new Book("HarryPotter4", 0));
            target.Buy(new Book("HarryPotter5", 0));

            var expected = 270m;
            Assert.AreEqual(expected, target.GetPrice());
        }

        [TestMethod()]
        public void Buy_One_HarryPotter1_One_HarryPotter2_One_HarryPotter3_One_HarryPotter4_Price_Should_Match()
        {
            var target = new ShoppingCar();

            target.Buy(new Book("HarryPotter1", 1));
            target.Buy(new Book("HarryPotter2", 1));
            target.Buy(new Book("HarryPotter3", 1));
            target.Buy(new Book("HarryPotter4", 1));
            target.Buy(new Book("HarryPotter5", 0));

            var expected = 320m;
            Assert.AreEqual(expected, target.GetPrice());
        }


        [TestMethod()]
        public void Buy_One_HarryPotter1_One_HarryPotter2_One_HarryPotter3_One_HarryPotter4_One_HarryPotter5_Price_Should_Match()
        {
            var target = new ShoppingCar();

            target.Buy(new Book("HarryPotter1", 1));
            target.Buy(new Book("HarryPotter2", 1));
            target.Buy(new Book("HarryPotter3", 1));
            target.Buy(new Book("HarryPotter4", 1));
            target.Buy(new Book("HarryPotter5", 1));

            var expected = 375m;
            Assert.AreEqual(expected, target.GetPrice());
        }
    }
}