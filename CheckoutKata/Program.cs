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

        public static Item itemA = new Item("A", 10);
        public static Item itemB = new Item("B", 15);
        public static Item itemC = new Item("C", 40);
        public static Item itemD = new Item("D", 55);

        static void Main(string[] args)
        {
            List<Promotion> promos = new List<Promotion>();
            promos.Add(new SpecificValueOff(itemB, 3, 40));
            promos.Add(new PercentageOff(itemD, 2, 25));

            basket.AddToBasket(itemA, 4);
            basket.AddToBasket(itemB, 7);
            basket.AddToBasket(itemC, 8);
            basket.AddToBasket(itemD, 3);

            decimal total = basket.CalculateTotal(promos);
            Console.WriteLine(total);
        }
    }
}
