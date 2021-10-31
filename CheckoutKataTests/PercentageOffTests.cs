using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CheckoutKata;
using System.Collections.Generic;

namespace CheckoutKataTests
{
    [TestClass]
    public class PercentageOffTests
    {
        public Item itemA = new Item("A", 10);
        public Item itemB = new Item("B", 15);
        public Item itemC = new Item("C", 40);
        public Item itemD = new Item("D", 55);

        [TestMethod]
        public void CalculateDiscountOnce()
        {
            List<Item> items = new List<Item>();
            items.Add(itemD);
            items.Add(itemD);

            PercentageOff PercentageOff = new PercentageOff(itemD, 2, 0.25M);

            decimal expectedDiscount = 27.5M;
            decimal discount = PercentageOff.CalculateDiscount(items);

            Assert.AreEqual(expectedDiscount, discount);
        }

        [TestMethod]
        public void CalculateDiscountMultiple()
        {
            List<Item> items = new List<Item>();
            items.Add(itemD);
            items.Add(itemD);
            items.Add(itemD);
            items.Add(itemD);
            items.Add(itemD);
            items.Add(itemD);

            PercentageOff PercentageOff = new PercentageOff(itemD, 2, 0.25M);

            decimal expectedDiscount = 82.5M;
            decimal discount = PercentageOff.CalculateDiscount(items);

            Assert.AreEqual(expectedDiscount, discount);
        }

        [TestMethod]
        public void CalculateDiscountNone()
        {
            List<Item> items = new List<Item>();
            items.Add(itemD);

            PercentageOff PercentageOff = new PercentageOff(itemD, 2, 0.25M);

            decimal expectedDiscount = 0;
            decimal discount = PercentageOff.CalculateDiscount(items);

            Assert.AreEqual(expectedDiscount, discount);
        }
    }
}
