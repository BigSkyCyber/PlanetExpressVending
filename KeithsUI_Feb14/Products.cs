using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine
{
    public class Product
    {
        private decimal price;
        private string id;

        public decimal Price
        {
            get {return price;}
            set {price = value;}
        }

        public string Id
        {
            get { return id; }
            set { id = "PRO#" + value; }
        }


    }
}