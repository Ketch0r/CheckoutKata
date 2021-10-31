using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CheckoutKata;
using System.Collections.Generic;

namespace CheckoutKataTests
{
    [TestClass]
    public class SpecificValueOffTests
    {
        public Item itemA = new Item("A", 10);
        public Item itemB = new Item("B", 15);
        public Item itemC = new Item("C", 40);
        public Item itemD = new Item("D", 55);

        [TestMethod]
        public void CalculateDiscountOnce()
        {
            List<Item> items = new List<Item>();
            items.Add(itemB);
            items.Add(itemB);
            items.Add(itemB);

            SpecificValueOff specificValueOff = new SpecificValueOff(itemB, 3, 40);

            decimal expectedDiscount = 5;
            decimal discount = specificValueOff.CalculateDiscount(items);

            Assert.AreEqual(expectedDiscount, discount);
        }

        [TestMethod]
        public void CalculateDiscountMultiple()
        {
            List<Item> items = new List<Item>();
            items.Add(itemB);
            items.Add(itemB);
            items.Add(itemB);
            items.Add(itemB);
            items.Add(itemB);
            items.Add(itemB);

            SpecificValueOff specificValueOff = new SpecificValueOff(itemB, 3, 40);

            decimal expectedDiscount = 10;
            decimal discount = specificValueOff.CalculateDiscount(items);

            Assert.AreEqual(expectedDiscount, discount);
        }

        [TestMethod]
        public void CalculateDiscountNone()
        {
            List<Item> items = new List<Item>();
            items.Add(itemB);

            SpecificValueOff specificValueOff = new SpecificValueOff(itemB, 3, 40);

            decimal expectedDiscount = 0;
            decimal discount = specificValueOff.CalculateDiscount(items);

            Assert.AreEqual(expectedDiscount, discount);
        }
    }
}
