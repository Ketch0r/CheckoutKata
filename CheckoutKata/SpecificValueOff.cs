using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    class SpecificValueOff : Promotion
    {
        protected decimal price;

        public SpecificValueOff(Item item, int numberOfItems, decimal price)
        {
            this.numberOfItems = numberOfItems;
            this.item = item;
            this.price = price;
        }
    }
}
