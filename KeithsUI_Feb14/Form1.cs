using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyLib;
namespace Vending_Machince
{
    public partial class Form1 : Form
    {
        DollarBill d1 = new DollarBill();
        Nickel n = new Nickel();
        Dime d = new Dime();
        Quarter q = new Quarter();
        List<CirculatingMoney> tempMoney;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempMoney.Add(d1);
            ShowtempMoney();
      

        }
        private void ShowtempMoney()
        {
            foreach (CirculatingMoney in txtAmountIn)
                txtAmountIn += CirculatingMoney.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            tempMoney.Add(n);
            ShowtempMoney();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tempMoney.Add(d);
            ShowtempMoney();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tempMoney.Add(q);
            ShowtempMoney();
        }
    }
}
