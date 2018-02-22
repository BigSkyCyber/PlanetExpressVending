using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine 
{
    public class Display
    {
        private decimal insertedMoney;

        public delegate void MoneyAddedHandler(decimal money);
        public event MoneyAddedHandler MoneyAdded;

        public decimal InsertedMoney
        {
            get
            {
                return insertedMoney;
            }
            set
            {
                insertedMoney += value;
                MoneyAdded(insertedMoney);
            }

        }
    }
}