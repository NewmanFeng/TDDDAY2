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
        public void Buy_One_HollyPoter1_Price_Should_Match()
        {
            var target = new ShoppingCar();

            target.Buy(new Book("HollyPoter1", 1));
            target.Buy(new Book("HollyPoter2", 0));
            target.Buy(new Book("HollyPoter3", 0));
            target.Buy(new Book("HollyPoter4", 0));
            target.Buy(new Book("HollyPoter5", 0));

            var expected = 100m;
            Assert.AreEqual(expected, target.GetPrice());
        }

        [TestMethod()]
        public void Buy_One_HollyPoter1_One_HollyPoter2_Price_Should_Match()
        {
            var target = new ShoppingCar();

            target.Buy(new Book("HollyPoter1", 1));
            target.Buy(new Book("HollyPoter2", 1));
            target.Buy(new Book("HollyPoter3", 0));
            target.Buy(new Book("HollyPoter4", 0));
            target.Buy(new Book("HollyPoter5", 0));

            var expected = 190m;
            Assert.AreEqual(expected, target.GetPrice());
        }
    }
}