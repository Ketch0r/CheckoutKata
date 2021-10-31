using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class Promotion
    {
        PromotionType type;
        int numberOfItems;
        Item item;

        public Promotion(PromotionType type, int numberOfItems, Item item)
        {
            this.type = type;
            this.numberOfItems = numberOfItems;
            this.item = item;
        }

        public PromotionType Type { get => type; set => type = value; }
        public int NumberOfItems { get => numberOfItems; set => numberOfItems = value; }
        public Item Item { get => item; set => item = value; }
    }
}
