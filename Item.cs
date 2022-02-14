using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public class Item
    {
        public Product Product { get; set; }
        public int Number { get; set; }

        public Item (Product p, int n)
        {
            this.Product = p;
            this.Number = n;
        }

    }
}
