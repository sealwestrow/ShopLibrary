using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public class SortByName : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
    public class SortByType : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return string.Compare(x.Type, y.Type);
        }
    }
    public class SortByTypeAndPrice : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            int c = string.Compare(x.Type, y.Type);
            if (c == 0)
            {
                c = x.Price.CompareTo(y.Price) * -1;
            }
            return c;    
        }
    }
}
