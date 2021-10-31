using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class SpecificValueOff : Promotion
    {
        private decimal _price;

        public SpecificValueOff(Item item, int numberOfItems, decimal price)
        {
            NumberOfItems = numberOfItems;
            Item = item;
            Price = price;
        }

        protected decimal Price { get => _price; set => _price = value; }

        public override decimal CalculateDiscount(List<Item> items)
        {
            int count = (from Item item in items
                        where item == Item
                        select item).Count();

            decimal timesToApplyDiscount = Math.Floor(new decimal(count / numberOfItems));

            if (timesToApplyDiscount > 0)
            {
                decimal oldItemTotal = item.Price * count;
                decimal discountedItemTotal = Price * timesToApplyDiscount;

                return oldItemTotal - discountedItemTotal;
            }
            else
                return 0;
        }
    }
}
