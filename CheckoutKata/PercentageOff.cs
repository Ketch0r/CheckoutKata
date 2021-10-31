using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class PercentageOff : Promotion
    {
        private int percentage;

        public PercentageOff(Item item, int numberOfItems, int percentage)
        {
            this.numberOfItems = numberOfItems;
            this.item = item;
            this.percentage = percentage;
        }

        public override decimal CalculateDiscount(List<Item> items)
        {
            throw new NotImplementedException();
        }
    }
}
