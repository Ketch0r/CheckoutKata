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
            items.Add(new Item()
            {
                Sku = "A",
                Price = 10
            });
            items.Add(new Item()
            {
                Sku = "B",
                Price = 10
            });
            items.Add(new Item()
            {
                Sku = "C",
                Price = 10
            });
            items.Add(new Item()
            {
                Sku = "D",
                Price = 10
            });
            #endregion items

            #region promos
            promos.Add(new Promotion
            {

            });
            #endregion promos
        }
    }
}
