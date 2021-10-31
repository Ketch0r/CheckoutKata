using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class Basket
    {
        public List<Item> Items = new List<Item>();

        public void AddToBasket(Item item, int quantity)
        {
            if (quantity < 1)
            { 
                Console.WriteLine("Quantity is 0, nothing to add.");
                return;
            }

            for (int i = 0; i < quantity; i++)
                Items.Add(item);
            Console.WriteLine($"Added {quantity} {item.Sku} to basket");
        }

        public decimal CalculateTotal(Promotion[] promos)
        {
            // add up list of item prices for a total

            // iterate promotions
                // check for number of item in basket for each promo
                // calculate how much discount should be applied
                // add that to a discount total

            // return total - discount

            return 0.00M;
        }
    }
}
