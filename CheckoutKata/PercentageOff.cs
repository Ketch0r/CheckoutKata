using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class PercentageOff : Promotion
    {
        private decimal percentage;

        public PercentageOff(Item item, int numberOfItems, decimal percentage)
        {
            NumberOfItems = numberOfItems;
            Item = item;
            Percentage = percentage;
        }

        public decimal Percentage { get => percentage; set => percentage = value; }

        public override decimal CalculateDiscount(List<Item> items)
        {
            // get the number of item in the order
            int count = (from Item item in items
                         where item == Item
                         select item).Count();

            // divide the count by number of items needed to get discount
            decimal timesToApplyDiscount = Math.Floor(new decimal(count / numberOfItems));

            if (timesToApplyDiscount > 0)
            {
                decimal discountedItemTotal = (item.Price * Percentage) * (timesToApplyDiscount * 2);

                if (count % 2 != 0)
                    discountedItemTotal += item.Price;
                    
                return discountedItemTotal;
            }
            else
                return 0;
        }
    }
}
