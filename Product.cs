using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public class Product
    {
        private string _name;
        private int _price;
        private string _type;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
                else
                    throw new ArgumentException("Неподходящее значение!");
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                    this._price = value;
                else
                    throw new ArgumentException("Неподходящее значение!");
            }
        }
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this._type = value;
                else
                    throw new ArgumentException("Неподходящее значение!");
            }
        }

        public Product(string name, int price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type; 
        }

        public override string ToString()
        {
            return string.Format("Name: {0} Price: {1} Type: {2}\n", this.Name, this.Price, this.Type);
        }

    }
}
