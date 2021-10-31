using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class Item
    {
        string _sku;
        decimal _price;

        public Item(string sku, decimal price)
        {
            _sku = sku;
            _price = price;
        }

        public string Sku { get => _sku; set => _sku = value; }
        public decimal Price { get => _price; set => _price = value; }
    }
}
