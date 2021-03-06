﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDDAY2.Tests
{
    [TestClass()]
    public class ShoppingCarTests
    {

        [TestMethod()]
        public void Buy_Nothing_Price_Should_Match()
        {
            var target = new ShoppingCar();

            target.Buy(new Book("HarryPotter1", 0));
            target.Buy(new Book("HarryPotter2", 0));
            target.Buy(new Book("HarryPotter3", 0));
            target.Buy(new Book("HarryPotter4", 0));
            target.Buy(new Book("HarryPotter5", 0));

            var expected = 0;
            Assert.AreEqual(expected, target.GetPrice());
        }

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

        [TestMethod()]
        public void Buy_One_HarryPotter1_One_HarryPotter2_Two_HarryPotter3_Price_Should_Match()
        {
            var target = new ShoppingCar();

            target.Buy(new Book("HarryPotter1", 1));
            target.Buy(new Book("HarryPotter2", 1));
            target.Buy(new Book("HarryPotter3", 2));
            target.Buy(new Book("HarryPotter4", 0));
            target.Buy(new Book("HarryPotter5", 0));

            var expected = 370m;
            Assert.AreEqual(expected, target.GetPrice());
        }

        [TestMethod()]
        public void Buy_One_HarryPotter1_Two_HarryPotter2_Two_HarryPotter3_Price_Should_Match()
        {
            var target = new ShoppingCar();

            target.Buy(new Book("HarryPotter1", 1));
            target.Buy(new Book("HarryPotter2", 2));
            target.Buy(new Book("HarryPotter3", 2));
            target.Buy(new Book("HarryPotter4", 0));
            target.Buy(new Book("HarryPotter5", 0));

            var expected = 460m;
            Assert.AreEqual(expected, target.GetPrice());
        }
    }
}