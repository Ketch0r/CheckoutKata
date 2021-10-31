using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CheckoutKata;
using System.Collections.Generic;

namespace CheckoutKataTests
{
    [TestClass]
    public class BasketTests
    {
        public Item itemA = new Item("A", 10);
        public Item itemB = new Item("B", 15);
        public Item itemC = new Item("C", 40);
        public Item itemD = new Item("D", 55);

        [TestMethod]
        public void AddToBasketTest()
        {
            // add a single item to the basket

            Basket basket = new Basket();
            int currentQuantity = basket.Items.Count;

            basket.AddToBasket(itemA, 1);

            Assert.AreEqual(currentQuantity + 1, basket.Items.Count);
        }

        [TestMethod]
        public void AddToBasketMultiple()
        {
            // add multiple items to basket at once

            int quantityToAdd = 3;

            Basket basket = new Basket();
            int currentQuantity = basket.Items.Count;

            basket.AddToBasket(itemA, quantityToAdd);

            Assert.AreEqual(currentQuantity + quantityToAdd, basket.Items.Count);
        }

        [TestMethod]
        public void CalculateTotalNoPromo()
        {
            decimal expectedTotal = 230;

            Basket basket = new Basket();

            basket.AddToBasket(itemA, 3);
            basket.AddToBasket(itemC, 5);

            decimal total = basket.CalculateTotal();

            Assert.AreEqual(expectedTotal, total);
        }

        [TestMethod]
        public void CalculateTotalSpecificValuePromo()
        {
            decimal expectedTotal = 0.00M;

            Basket basket = new Basket();
            List<Promotion> promos = new List<Promotion>();
            promos.Add(new SpecificValueOff(itemB, 3, 40));

            basket.AddToBasket(itemB, 6);

            decimal total = basket.CalculateTotal(promos);

            Assert.AreEqual(expectedTotal, total);
        }

        [TestMethod]
        public void CalculateTotalPercentagePromo()
        {
            decimal expectedTotal = 0.00M;

            Basket basket = new Basket();
            List<Promotion> promos = new List<Promotion>();
            promos.Add(new PercentageOff(itemD, 2, 25));

            basket.AddToBasket(itemD, 4);

            decimal total = basket.CalculateTotal(promos);

            Assert.AreEqual(expectedTotal, total);
        }
    }
}
