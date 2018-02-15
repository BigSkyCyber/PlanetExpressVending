using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vending_Machince
{
    public class Customer
    {
        private WorldOfMoney world;

        public VendingMachine currentVendingMachine
        {
            get => default(int);
            set
            {
            }
        }

        public void UseVendingMachine()
        {
            throw new System.NotImplementedException();
        }

        public void GetMoneyFromWallet()
        {
            throw new System.NotImplementedException();
        }

        public void PutMoneyInVendingMachine()
        {
            throw new System.NotImplementedException();
        }

        public void SelectProdectFromVendingMaching()
        {
            throw new System.NotImplementedException();
        }

        public void StopUsingVendingMachine()
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
    }
}