using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine
{
    public class Customer
    {
        private WorldOfMoney world;
        private int currentVendor;

        public int WalkIntoVendor
        {
            get => default(int);
            set
            {
            }
        }

        public void GetMoneyFromWallet()
        {
            throw new System.NotImplementedException();
        }

        public string OpenBankAccount(string cash, string bank)
        {
            throw new System.NotImplementedException();
        }

        public void GetMoneyFromATM()
        {
            throw new System.NotImplementedException();
        }

        public BunchOfMoney AddMoneyToWallet()
        {
            throw new System.NotImplementedException();
        }

        public void GetProductFromVendor()
        {
            throw new System.NotImplementedException();
        }
    }
}