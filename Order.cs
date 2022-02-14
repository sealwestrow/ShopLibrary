using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public class Order
    {
        public List<Item> List { get; set; }
        public Customer Customer { get; set; }

        public Order(List<Item> list, Customer customer)
        {
            this.List = list;
            this.Customer = customer;          
        }

        public bool Remove (Product product)
        {
            foreach (var item in List)
            {
                if (item.Product == product)
                {
                    item.Number--;
                    if (item.Number == 0)
                        return List.Remove(item);
                }                                   
            }
            return false;
        }
        public void Add (Product product, int number)
        {
            List.Add(new Item(product, number));
        }

        public IEnumerable<Item> GetAll()
        {
            return (IEnumerable<Item>)List;
        }

        public double GetDiscount()
        {
            int a = Customer.Amount;
            if (a < 10)
                return 3;
            else if (a > 15)
                return 10;
            else
                return 5;
        }

        public double GetTotal()
        {
            int fp = 0;
            foreach (var item in List)
            {
                fp += item.Product.Price * item.Number;
            }

            if (Customer != null)
            {
                Customer.Total += (int)(fp - fp * (this.GetDiscount() / 100));
                return (int)(fp - fp * (this.GetDiscount() / 100));
            }
            else
            {
                return fp;
            }
        }
    }
}
