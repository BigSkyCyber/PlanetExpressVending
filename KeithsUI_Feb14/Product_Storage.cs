using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine
{

    public class ProductStorage
    {
        private List<Product> products = new List<Product>();

        public ProductStorage()
        {
          //Products = database.getById(c);
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public void RemoveProducts()
        {
            throw new System.NotImplementedException();
        }

        public void AddProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}







//foreach (productId p in products )
   //is userInput == productId[0].price