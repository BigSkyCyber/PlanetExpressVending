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

namespace VendingMachine
{
    public partial class VendingMachinefrm : Form
    {

        public static Display display = new Display();
        DollarBill dollar = new DollarBill();
        Penny penny = new Penny();
        VendingMachine Vending = new VendingMachine();


        public VendingMachinefrm()
        {
            InitializeComponent();
        }

        private void VendingMachinefrm_Load(object sender, EventArgs e)
        {
            display.MoneyAdded += new Display.MoneyAddedHandler(displayMoney);
        }

        private void displayMoney(decimal money)
        {
            txtAmountInserted.Text = money.ToString("c");
        }

        private void btnDollarBill_Click(object sender, EventArgs e)
        {
            Vending.InputMoney(penny);
        }
    }
}
