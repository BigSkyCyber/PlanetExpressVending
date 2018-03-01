using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine
{
    public class Product
    {
        private int price;

        public Product(int price)
        {
            this.Price = price;
        }

        public int Price
        {
            get {return price;}
            set
            {
                price = value;
            }
        }

        public int Inventory
        {
            get => default(int);
            set
            {
            }
        }
    }
}