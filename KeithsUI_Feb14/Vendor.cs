using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoneyLib;

namespace VendingMachine
{
    public abstract class Vendor
    {
        protected Storage cashStorage = new Storage();

        public virtual void InputMoney(CirculatingMoney money)
        {
        }
        public virtual void TakeMoney(CirculatingMoney money)
        {
        }
    }
}







