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
        string selectedId;


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



        private void btnCocaCola_Click(object sender, EventArgs e)
        {
            GiveCostumerProduct("Coke");
        }

        private void btnCrush_Click(object sender, EventArgs e)
        {
            GiveCostumerProduct("Crush");
        }

        private void btnFanta_Click(object sender, EventArgs e)
        {
            GiveCostumerProduct("Fanta");
        }

        private void btnPotLays_Click(object sender, EventArgs e)
        {
            GiveCostumerProduct("PotLays");
        }

        private void btnSourLays_Click(object sender, EventArgs e)
        {
            GiveCostumerProduct("SourLays");
        }

        private void btnChaletLays_Click(object sender, EventArgs e)
        {
            GiveCostumerProduct("ChaletLays");
        }

        private void GiveCostumerProduct(string id)
        {

        }
    }
}
