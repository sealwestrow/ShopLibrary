using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public class Customer
    {
        private string _name;
        private int _amount;
        private int _total;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this._name = value;
                else
                    throw new ArgumentException("Неподходящее значение!");
            }
        }
        public int Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                this._amount = value;
            }
        }
        public int Total
        {
            get
            {
                return _total;
            }
            set
            {
                this._total = value;
            }
        }

        public Customer(string name, int amount, int total)
        {
            this.Name = name;
            this.Amount = amount;
            this.Total = total;
        }


    }
}
