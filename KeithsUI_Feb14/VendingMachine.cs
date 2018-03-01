using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoneyLib;

namespace VendingMachine
{
    public class VendingMachine : Vendor
    {
        public VendingMachine()
        {
            ProductStorage Inventory = new ProductStorage();
        }

        public override void InputMoney(CirculatingMoney money)
        {
            cashStorage.AddMoney(money);
            VendingMachinefrm.display.InsertedMoney = money.Value;
        }

        public override void TakeMoney(CirculatingMoney money)
        {
            cashStorage.RemoveMoney(money);
        } 
    }
}

