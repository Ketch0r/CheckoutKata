using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public abstract class Promotion
    {
        protected Item item;
        protected int numberOfItems;

        public int NumberOfItems { get => numberOfItems; set => numberOfItems = value; }
        public Item Item { get => item; set => item = value; }

        public abstract decimal CalculateDiscount(List<Item> items);
    }
}
