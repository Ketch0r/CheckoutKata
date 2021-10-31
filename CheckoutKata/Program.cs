using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    class Program
    {
        private static List<Item> items = new List<Item>();
        private static List<Promotion> promos = new List<Promotion>();
        private static Basket basket = new Basket();

        static void Main(string[] args)
        {
            Setup();


        }

        private static void Setup()
        {
            #region items
            Item itemA = new Item()
            {
                Sku = "A",
                Price = 10
            };
            Item itemB = new Item()
            {
                Sku = "B",
                Price = 10
            }; 
            Item itemC = new Item()
            {
                Sku = "C",
                Price = 10
            }; 
            Item itemD = new Item()
            {
                Sku = "D",
                Price = 10
            };
            items.AddRange(new Item[] { itemA, itemB, itemC, itemD});
            #endregion items

            #region promos
            promos.Add(new SpecificValueOff(itemB, 3, 40));
            promos.Add(new PercentageOff(itemD, 2, 25));
            #endregion promos
        }
    }
}
