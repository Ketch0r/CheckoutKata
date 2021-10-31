using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CheckoutKata;

namespace CheckoutKataTests
{
    [TestClass]
    public class BasketTests
    {
        [TestMethod]
        public void AddToBasketTest()
        {
            // add a single item to the basket

            Item item = new Item();
            item.Sku = "A";
            item.Price = 1;

            Basket basket = new Basket();
            int currentQuantity = basket.Items.Count;

            basket.AddToBasket(item, 1);

            Assert.AreEqual(currentQuantity + 1, basket.Items.Count);
        }

        public void AddToBasketMultiple()
        {
            // add multiple items to basket at once

            Item item = new Item();
            item.Sku = "A";
            item.Price = 1;

            int quantityToAdd = 3;

            Basket basket = new Basket();
            int currentQuantity = basket.Items.Count;

            basket.AddToBasket(item, quantityToAdd);

            Assert.AreEqual(currentQuantity + quantityToAdd, basket.Items.Count);
        }
    }
}
