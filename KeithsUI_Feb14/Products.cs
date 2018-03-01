using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine
{
    public class Product
    {
        private decimal price;
        private int id;

        public Product(decimal price)
        {
            this.Price = price;
        }

        public decimal Price
        {
            get {return price;}
            set {price = value;}
        }

        public int Id
        {
            get => default(int);
            set
            {
            }
        }
    }
}