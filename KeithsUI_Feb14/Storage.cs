﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoneyLib;

namespace VendingMachine
{
    public class Storage
    {
        private List<CirculatingMoney> listOfMoney = new List<CirculatingMoney>();

        public void AddMoney(CirculatingMoney money)
        {
            listOfMoney.Add(money);
        }

        public void RemoveMoney(CirculatingMoney money)
        {
            listOfMoney.Remove(money);
        }
    }
}